using AutoMapper;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using BlogProject_5175.WEB.Models.DTOs;
using BlogProject_5175.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IAppUserRepository appUserRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IMapper mapper;

        public UserController(IAppUserRepository appUserRepository,UserManager<IdentityUser> userManager,IMapper mapper) 
        {
            this.appUserRepository = appUserRepository;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDTO createUserDTO)
        {
            if (ModelState.IsValid) 
            {
                string newId = Guid.NewGuid().ToString();
                IdentityUser ıdentityUser = new IdentityUser { Email = createUserDTO.Mail, UserName = createUserDTO.UserName, Id = newId };
                IdentityResult result = await userManager.CreateAsync(ıdentityUser, createUserDTO.Password);
                

                if (result.Succeeded) // create başarılıysa
                {
                    await userManager.AddToRoleAsync(ıdentityUser, "Member");    // rol ekledik.
                    
                    var user = mapper.Map<AppUser>(createUserDTO);
                    user.IdentityId = newId;
                    
                    if (createUserDTO.ImagePath!=null)      // fotoğraf alındıysa
                    {
                        using var image = Image.Load(createUserDTO.ImagePath.OpenReadStream());
                        image.Mutate(a=>a.Resize(100,100));  // mutate :  değiştirmek demek aslın / fotoğraf yeniden şekilleniyor
                        image.Save($"wwwroot/images/{user.UserName}.jpg"); // root altına foto kaydı için dosya açtık ve yol verdik.
                        user.Image = ($"/images/{user.UserName}.jpg"); // veritabanına dosya yolunu kaydediyor

                        user.Statu = Statu.Passive; // Kullanıcının Statusu admin onayı için pasife çekildi
                        appUserRepository.Create(user);
                        
                        return RedirectToAction("Login","Home");  // ilk kez kayıt olan kulllanıcıyı login sayfasına yönlendir.
                    }



                }

            }
            return View(createUserDTO);  // kullanıcı x bir sebepten başarısız olduysa viewa geri dönsün.
        }
    }
}
