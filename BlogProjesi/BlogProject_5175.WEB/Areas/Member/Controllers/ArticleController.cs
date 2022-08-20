using AutoMapper;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using BlogProject_5175.WEB.Areas.Member.Models.DTOs;
using BlogProject_5175.WEB.Areas.Member.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BlogProject_5175.WEB.Areas.Member.Controllers
{
    [Area("Member")]

    public class ArticleController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IMapper mapper;
        private readonly IArticleRepository articleRepository;
        private readonly IAppUserRepository appUserRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ICommentRepository commentRepository;
        private readonly ILikeRepository likeRepository;
        private readonly IArticleCategoryRepository articleCategoryRepository;

        public ArticleController(UserManager<IdentityUser> userManager, IMapper mapper, IArticleRepository articleRepository, IAppUserRepository appUserRepository,
            ICategoryRepository categoryRepository, ICommentRepository commentRepository, ILikeRepository likeRepository,IArticleCategoryRepository articleCategoryRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.articleRepository = articleRepository;
            this.appUserRepository = appUserRepository;
            this.categoryRepository = categoryRepository;
            this.commentRepository = commentRepository;
            this.likeRepository = likeRepository;
            this.articleCategoryRepository = articleCategoryRepository;
        }

        private void FillCategories()
        {
            ViewBag.kategoriler = categoryRepository.GetDefaults(x => x.Statu != Statu.Passive);
        }

        public async Task<IActionResult> Create()
        {
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser user = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            ArticleCreateDTO dto = new ArticleCreateDTO()
            {
                Categories = categoryRepository.GetByDefaults
                (
                    selector: a => new GetCategoryDTO
                    {
                        ID = a.ID,
                        Name = a.Name
                    },
                    expression: a => a.Statu != Statu.Passive
                ),
                AppUserID = user.ID
            };
            return View(dto);

        }

        [HttpPost]
        public IActionResult Create(ArticleCreateDTO dto, int[] Categories)
        {
            ArticleCategory articleCategory; //Kategorileri databaseye eklemek için kullanacağımız şablon

            Article makaleKontrol = articleRepository.GetDefault(x => x.Title == dto.Title); //yazılan makalenin başlığı veritabanında var mı
            if (makaleKontrol != null) //eğer adminin yazdığı makale zaten varsa
            {
                return RedirectToAction("Detail", "Article", new { makaleKontrol.ID });
            }
            if (ModelState.IsValid)  // validasyon tamamsa
            {
                var article = mapper.Map<Article>(dto);
                article.CategoryID = 1;
                var karakterSayisi = article.Content.Count(x => x == ' ') + 1;
                var okunmaSuresi = (karakterSayisi / 100) * 2;
                article.ReadTime = okunmaSuresi;

                if (article.ImagePath != null) // fotoğraf alınabildiyse
                {
                    using var image = Image.Load(dto.ImagePath.OpenReadStream());
                    image.Mutate(a => a.Resize(100, 100));  // mutate :  değiştirmek demek aslın / fotoğraf yeniden şekilleniyor
                    Guid guid = Guid.NewGuid();
                    image.Save($"wwwroot/images/{guid}.jpg"); // root altına foto kaydı için dosya açtık ve yol verdik.
                    article.Image = ($"/images/{guid}.jpg"); // veritabanına dosya yolunu kaydediyor

                    foreach (var item in Categories)
                    {
                        Category Kategori = categoryRepository.GetDefault(x => x.ID == item);
                        article.ArticleCategories.Add(articleCategory = new ArticleCategory { Category = Kategori, CategoryID = Kategori.ID, Article = article, ArticleID = article.ID });

                    }

                    articleRepository.Create(article);
                    return RedirectToAction("Detail", "Article", new { article.ID });
                }
            }
            ArticleCreateDTO kategoriler = new ArticleCreateDTO()
            {
                Categories = categoryRepository.GetByDefaults
                (
                    selector: a => new GetCategoryDTO
                    {
                        ID = a.ID,
                        Name = a.Name
                    },
                    expression: a => a.Statu != Statu.Passive
                )
            }; // eğer create başarısız olursa kategoriler tekrardan view'a yollanıyor
            return View(kategoriler);

        }

        public async Task<IActionResult> List()
        {
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser user = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            // NOT => veritabanında oluşturusunun biz olduğumuz makaleleri görüntülemek istediğimiz için önce kendimizi bulduk.

            var articleList = articleRepository.GetByDefaults
                (
                    selector: a => new GetArticleVM()
                    {
                        ArticleID = a.ID,
                        CategoryName = a.Category.Name,
                        Title = a.Title,
                        Content = a.Content,
                        Image = a.Image,
                        UserFullName = a.AppUser.FullName
                    },
                    expression: a => a.Statu != Statu.Passive && a.AppUserID == user.ID,
                    include: a => a.Include(a => a.AppUser).Include(a => a.Category)
                //  ,orderby : a=>a.OrderByDescending(a=>a.CreateDate)

                );

            return View(articleList);

        }


        public IActionResult Update(int id)
        {
           Article article = articleRepository.GetDefault(a => a.ID == id);
            List<ArticleCategory> categoryList = articleCategoryRepository.GetDefaults(a => a.ArticleID == id);
            
            var updatedArticle = mapper.Map<ArticleUpdateDTO>(article);
            updatedArticle.ArticleCategories = categoryList;
            FillCategories();

            return View(updatedArticle);
        }

        
        [HttpPost]
        public IActionResult Update(ArticleUpdateDTO dto, int[] SecilenKategori)
        {
            Article articleName = articleRepository.GetDefault(a => a.Title == dto.Title);
            if (articleName != null && articleName.Title != dto.PreviousTitle)
            {
                FillCategories();
                dto.ArticleCategories = articleCategoryRepository.GetDefaults(x => x.ArticleID == dto.ID);
                return View(dto);
            }
            if (ModelState.IsValid)
            {               
                 var article = mapper.Map<Article>(dto);
                article.CategoryID = 1;
                var kelimeSayisi = article.Content.Count(x => x == ' ') + 1;
                var okunmaSuresi = (kelimeSayisi / 100) * 2;
                article.ReadTime = okunmaSuresi;

                List<ArticleCategory> articleCategories = articleCategoryRepository.GetDefaults(x => x.ArticleID == article.ID); //makalenin kategorileri alınıyor
                List<Category> CategoryList = categoryRepository.GetDefaults(x => x.Statu != Statu.Passive); //Tüm Kategorilerin Listesi alınıyor ve foreach ile dönülüyor                           
                foreach (var item in CategoryList.ToList())
                {
                    Category Kategori = categoryRepository.GetDefault(x => x.ID == item.ID); //itemdan gelen id ile kategori bulundu
                    ArticleCategory articleCategoryTable = articleCategoryRepository.GetDefault(x => x.ArticleID == article.ID && x.CategoryID == Kategori.ID);
                    //Şu Anda döngüde olan kategori var ise ArticleCategory'si bulundu
                    List<Category> secilmemisKategori = categoryRepository.GetDefaults(x => x.ArticleCategories != articleCategories); //Seçilmeyen kategoriler


                    if (SecilenKategori.Contains(item.ID)) //Kullanıcının seçtiği kategoriler bulundu
                    {
                        ArticleCategory articleCategory = new ArticleCategory { Category = Kategori, CategoryID = Kategori.ID, Article = article, ArticleID = article.ID };

                        if (!articleCategories.Contains(articleCategoryTable)) //eğer articleCategory tablosunda böyle bir kayıt yok ise create edildi
                        {
                            articleCategoryRepository.Create(articleCategory);
                        }
                    }
                    else if (articleCategoryTable != null && secilmemisKategori.Contains(articleCategoryTable.Category))
                    {//Eğer ArticleCategory tablosunda böyle bir kayıt varsa fakat seçilmemişse delete edildi                                                                                              
                        articleCategoryRepository.Delete(articleCategoryTable);

                    }
                }
                if (article.ImagePath != null) // fotoğraf alınabildiyse
                {
                    System.IO.File.Delete($"wwwroot/{dto.Image}"); //view'dan aldığımız önce ki resmi siliyoruz.
                    using var image = Image.Load(dto.ImagePath.OpenReadStream());
                    image.Mutate(a => a.Resize(100, 100));  // mutate :  değiştirmek demek aslın / fotoğraf yeniden şekilleniyor
                    Guid guid = Guid.NewGuid();
                    image.Save($"wwwroot/images/{guid}.jpg"); // root altına foto kaydı için dosya açtık ve yol verdik.
                    article.Image = ($"/images/{guid}.jpg"); // veritabanına dosya yolunu kaydediyor


                    articleRepository.Update(article);

                    return RedirectToAction("Detail", new { id = article.ID });


                }
                else
                {
                    article.Image = dto.Image; //önce ki resmi tekrar atıyoruz.
                    articleRepository.Update(article);
                    return RedirectToAction("Detail", new { id = article.ID });
                }

            }
            FillCategories(); //güncelleme başarısızsa hata alınmaması için kategorilerin listesi tekrar view'a yollanıyor.
            dto.ArticleCategories = articleCategoryRepository.GetDefaults(x => x.ArticleID == dto.ID);
            return View(dto);
        }

        public IActionResult Delete(int id)
        {
            Article silinecekMakale = articleRepository.GetDefault(a => a.ID == id);
            articleRepository.Delete(silinecekMakale);
            return RedirectToAction("List");
        }

        public IActionResult Filter(Category dto)
        {
            List<ArticleCategory> articleCategories = articleCategoryRepository.GetDefaults(x => x.CategoryID == dto.ID);
            List<int> filtre = articleCategories.Select(x => x.ArticleID).ToList();
            var articleList = articleRepository.GetByDefaults
               (
                   selector: a => new GetArticleVM()
                   {
                       ArticleID = a.ID,
                       CategoryName = a.Category.Name,
                       Title = a.Title,
                       Content = a.Content,
                       Image = a.Image,
                       UserFullName = a.AppUser.FullName,
                       CreateDate = a.CreateDate,
                       AppUserID = a.AppUserID
                   },
                   expression: a => a.Statu != Statu.Passive && filtre.Contains(a.ID),
                   orderby: a => a.OrderByDescending(a => a.CreateDate)
               ).Take(5);
            if (articleCategories.Count != 0)
            {
                ViewBag.kategori = categoryRepository.GetDefault(a => a.ID == articleCategories[0].CategoryID).Name;
            }

            return View(articleList.ToList());
        }

        public async Task<IActionResult> Detail(Article dto)
        {
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser user = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id); //kendimizi buluyoruz
            ViewBag.user = user.ID;

            Article article = articleRepository.GetDefault(x => x.ID == dto.ID);

            article.ReadCount = article.ReadCount + 1; //Makalenin okunma sayısı arttırıldı ve update edildi
            articleRepository.Update(article);

            article.ArticleCategories = articleCategoryRepository.GetDefaults(x => x.ArticleID == article.ID); // makalenin kategorilerinin id'si bulundu
            foreach (var item in article.ArticleCategories)
            {
                item.Category = categoryRepository.GetDefault(x => x.ID == item.CategoryID); //makalenin kategorilerinin id'sinden kategorilerin kendileri bulundu
            }
            article.AppUser = appUserRepository.GetDefault(x => x.ID == article.AppUserID);
            article.Comments = commentRepository.GetDefaults(x => (x.ArticleID == article.ID) && (x.Statu != Statu.Passive));

            article.Likes = likeRepository.GetDefaults(x => x.ArticleID == article.ID); //makaleyi kimler beğenmiş

            ViewBag.begenmeSayisi = article.Likes.Count; //makaleyi kaç kişinin beğendiği bilgisi viewbag olarak tutuldu

            foreach (var item in article.Comments) //hangi yorumun hangi kullanıcıya ait olduğu bulunuyor.
            {
                item.AppUser = appUserRepository.GetDefault(a => a.ID == item.AppUserID);
            }

            ViewBag.aktifKullanici = user.ID; //View'da kullanılacak
                 
            return View(article);
        }

        [HttpPost]
        public async Task<IActionResult> Comments(Comment data)
        {
            if (data.Text == null)
            {
                return RedirectToAction("Detail", new { id = data.ArticleID });
            }
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser user = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            data.AppUserID = user.ID; //appuserid yi yorum yapan kulllanıcının idsine eşitliyoruz.
            commentRepository.Create(data);
            return RedirectToAction("Detail", new { id = data.ArticleID });
        }

        public IActionResult DeleteComment(int id)
        {
            Comment silinecekComment = commentRepository.GetDefault(a => a.ID == id);
            commentRepository.Delete(silinecekComment);
            return RedirectToAction("Detail", new { id = silinecekComment.ArticleID });
        }


        [HttpPost]
        public async Task<IActionResult> Like(Like data)
        {

            List<Like> likes = likeRepository.GetDefaults(x => x.ArticleID == data.ArticleID);
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser user = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id); //kendimizi buluyoruz

            foreach (var item in likes.ToList())
            {
                if (item.AppUserID == user.ID) //eğer kullanıcı bu makaleyi beğendiyse
                {
                    likeRepository.Delete(data);
                    return RedirectToAction("Detail", new { id = data.ArticleID });
                }
            }
            likeRepository.Create(data);

            return RedirectToAction("Detail", new { id = data.ArticleID });
        }




    }
}
