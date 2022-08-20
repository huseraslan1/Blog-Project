using BlogProject_5175.DAL.Repositories.Concrete;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using BlogProject_5175.Models.Enums;
using BlogProject_5175.WEB.Models;
using BlogProject_5175.WEB.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IAppUserRepository appUserRepository;
        private readonly IArticleRepository articleRepository;

        public HomeController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager,IAppUserRepository appUserRepository, IArticleRepository articleRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.appUserRepository = appUserRepository;
            this.articleRepository = articleRepository;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            if (ModelState.IsValid) // validasyon tamamsa
            {
                IdentityUser identityUser =await userManager.FindByEmailAsync(dto.Mail);
                if (identityUser!=null)  // içerde bu maile sahip biri varsa 
                {
                   await signInManager.SignOutAsync();  // içerdeki cookkide biri varsa silinsin
                   
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(identityUser,dto.Password,true,true);
                    if (result.Succeeded)
                    {
                        var FindUser = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id); // Kullanıcı bulundu
                        if (FindUser.Statu !=Statu.Passive) // Bulduğumuz kullanıcı admin tarafından onaylanmışsa member alanına geçiş yapılır
                        {
                            string role = (await userManager.GetRolesAsync(identityUser)).FirstOrDefault();
                            return RedirectToAction("Index", "AppUser", new { area = role }); // localostNo/area/appUser/index
                        }
                        else //Eğer statu pasifse kullanıcıya henüz onaylanmadığının mesajını vermek için tempdata oluşturuldu
                        {
                                TempData["sonuc"] = 1;
                        }
                    }
                }
            }

            return View(dto);
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {

            return View(articleRepository.GetDefault(a=>a.ID==id));
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
