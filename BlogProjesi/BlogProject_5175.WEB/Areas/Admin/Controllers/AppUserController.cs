using AutoMapper;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using BlogProject_5175.Models.Enums;
using BlogProject_5175.WEB.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppUserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IAppUserRepository appUserRepository;
        private readonly IArticleRepository articleRepository;
        private readonly ICommentRepository commentRepository;
        private readonly IPreviousPasswordRepository previousPasswordRepository;
        private readonly IMapper mapper;

        public AppUserController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager,IAppUserRepository appUserRepository,
             IArticleRepository articleRepository, ICommentRepository commentRepository,IPreviousPasswordRepository previousPasswordRepository, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.appUserRepository = appUserRepository;
            this.articleRepository = articleRepository;
            this.commentRepository = commentRepository;
            this.previousPasswordRepository = previousPasswordRepository;
            this.mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            IdentityUser identityUser =await  userManager.GetUserAsync(User);
            AppUser user = appUserRepository.GetDefault(a=>a.IdentityId==identityUser.Id);
            if (user!=null)
            {
                return View(user);
            }
            return Redirect("~/");
        }

        public async Task<IActionResult> List()
        {
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser user = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            List<AppUser> list = appUserRepository.GetDefaults(a => a.Statu != Statu.Passive && a.ID != user.ID); //pasifler ve adminin kendisi listte gösterilmiyor.
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            AppUser appuser = appUserRepository.GetDefault(a => a.ID == id);

            appuser.Articles = articleRepository.GetDefaults(a => a.AppUserID == appuser.ID); //Kullanıcının yazdığı makaleler bulunuyor  
            foreach (var item in appuser.Articles)                                           
            {
                articleRepository.Delete(item); //Kullanıcının yazdığı makalelerde pasife alınıyor
            }
            appUserRepository.Delete(appuser); // kullanıcı pasife alınıyor
            return RedirectToAction("List");

        }

        public IActionResult UnconfirmedUser() // Pasif olanların listesi alınarak adminin onayına sunuldu
        {
            List<AppUser> list = appUserRepository.GetDefaults(a => a.Statu == Statu.Passive);
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> UnconfirmedUser(string button, int id)
        {
            AppUser appUser = appUserRepository.GetDefault(a => a.ID == id); //AppUsers tablosundan silmek için
            var user = await userManager.FindByIdAsync(appUser.IdentityId); //databasede ki AspNetUsers Tablosundan silmek için

            appUser.Articles = articleRepository.GetDefaults(a => a.AppUserID == appUser.ID); //Kullanıcının yazdığı makaleler bulunuyor
            if (button == "confirm")
            {
                foreach (var item in appUser.Articles) //Kullanıcının yazdığı makalelerde aktife alınıyor
                {
                    item.Statu = Statu.Active;
                    articleRepository.Update(item);
                }
                appUser.Statu = Statu.Active;             
                appUserRepository.Update(appUser); //kullanıcı aktif oluyor
                return RedirectToAction("List");
            }
            else
            {
                appUserRepository.DeleteFromDatabase(appUser); // kullanıcı AppUser tablosundan silindi
                await userManager.DeleteAsync(user); //Kullanıcı AspNetUsers tablosundan silindi
            }
            return RedirectToAction("UnconfirmedUser");
        }

        public async Task<IActionResult> UserDetail(int id)
        {
            AppUser author;

            if (id == 0) // Eğer gelen id parametresi 0 ise kullanıcı ana sayfadan kendi profiline ulaşmak istemektedir. Bu yüzden kendimizi buluyoruz.
            {            
                IdentityUser identityUser = await userManager.GetUserAsync(User);
                 author = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            }
            else
            {
                 author = appUserRepository.GetDefault(a => a.ID == id);
            }

            author.Articles = articleRepository.GetDefaults(a => a.AppUserID == author.ID);
            author.Comments = commentRepository.GetDefaults(a => a.AppUserID == author.ID);

            foreach (var item in author.Comments) //hangi yorumun hangi makaleye ait olduğu bulunuyor.
            {
                item.Article = articleRepository.GetDefault(a => a.ID == item.ArticleID);
            }
            return View(author);
        }

        public async Task<IActionResult> UserSettings()
        {
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser appUser = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            var updatedUser = mapper.Map<UpdateUserDTO>(appUser);

            updatedUser.Mail = identityUser.Email;
            return View(updatedUser);
        }

        [HttpPost]
        public async Task<IActionResult> UserSettings(UpdateUserDTO dto)
        {
            IdentityUser identityUser = await userManager.GetUserAsync(User); // Güncellenecek kullanıcının önce ki bilgileri
            if (ModelState.IsValid && dto.OldPassword != null)
            {
                var mailVarMi = await userManager.FindByEmailAsync(dto.Mail); // dtodan gelen mail sistemde var mı
                var usernameVarMi = await userManager.FindByNameAsync(dto.UserName); //dtodan gelen Username sistemde var mı
                if (dto.OldPassword != dto.Password) //Kullanıcı Şifresini değiştirmişse
                {
                    List<PreviousPassword> previousPasswords = previousPasswordRepository.GetDefaults(x => x.AppuserID == dto.ID);
                    PreviousPassword articleCategory = new PreviousPassword { AppuserID = dto.ID, PPassword = dto.OldPassword, ChangeDate = DateTime.Now };

                    foreach (var item in previousPasswords)
                    {
                        if (item.PPassword == dto.Password)
                        {
                            dto.Mail = identityUser.Email;
                            TempData["sonuc"] = 1; //toastr ile mesaj verilecek
                            return View(dto);
                        }
                    }
                    if (previousPasswords.Count == 3) // eğer şifre zaten 3 kere değiştirilmişse
                    {
                        var enEskiSifre = previousPasswords.OrderByDescending(x => x.ChangeDate).Last(); //tarihine göre sıralıyoruz
                        previousPasswordRepository.Delete(enEskiSifre); //Tarihi en eski olan Kayıtı siliyoruz
                    }

                    previousPasswordRepository.Create(articleCategory); //Kullanıcının önce ki şifresini ekliyoruz

                }
                var appUser = mapper.Map<AppUser>(dto);

                if (dto.ImagePath == null) // eğer kullanıcı yeni fotoğraf yüklemediyse mevcut fotoğrafını alıp fotoğraf ekleme kısmını atlıyoruz.
                {
                    appUser.Image = dto.Image;
                }
                else
                {
                    System.IO.File.Delete($"wwwroot/{dto.Image}");
                    using var image = Image.Load(dto.ImagePath.OpenReadStream());
                    image.Mutate(a => a.Resize(100, 100));  // mutate :  değiştirmek demek aslın / fotoğraf yeniden şekilleniyor
                    Guid guid = Guid.NewGuid();
                    image.Save($"wwwroot/images/{guid}.jpg"); // root altına foto kaydı için dosya açtık ve yol verdik.
                    appUser.Image = ($"/images/{guid}.jpg"); // veritabanına dosya yolunu kaydediyor
                                                             // 3 kere aynı şifre
                }
                if ((dto.Mail == identityUser.Email || mailVarMi == null) && (dto.UserName.ToLower() == identityUser.UserName.ToLower() || usernameVarMi == null))
                //sistemde böyle bir mail var mı veya aynı kullanıcıya mı ait VE böyle bir username var mı varsa aynı kullanıcıya mı ait
                {
                    appUser.IdentityId = identityUser.Id;

                    await userManager.RemovePasswordAsync(identityUser);
                    await userManager.AddPasswordAsync(identityUser, appUser.Password);


                    appUserRepository.Update(appUser);
                    return RedirectToAction("UserDetail", new { appUser.ID });
                }

            }
            dto.Mail = identityUser.Email;
            return View(dto);
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return Redirect("~/");       // areasız başlangıç sayfasına yani home/index
        } 
    }
}
