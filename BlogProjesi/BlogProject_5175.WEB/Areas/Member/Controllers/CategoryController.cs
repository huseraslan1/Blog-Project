using AutoMapper;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using BlogProject_5175.WEB.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175.Models.Enums;
using Microsoft.AspNetCore.Identity;
using BlogProject_5175.DAL.Context;

namespace BlogProject_5175.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IAppUserRepository appUserRepository;
        private readonly IUserFollowedCategoryRepository userFollowedCategoryRepository;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper,UserManager<IdentityUser> userManager,IAppUserRepository appUserRepository,IUserFollowedCategoryRepository userFollowedCategoryRepository)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.appUserRepository = appUserRepository;
            this.userFollowedCategoryRepository = userFollowedCategoryRepository;
        }


        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateCategoryDTO dto)
        {
            Category kategoriKontrol = categoryRepository.GetDefault(x => x.Name == dto.Name); //yazılan kategorinin başlığı veritabanında var mı
            if (kategoriKontrol != null) //eğer kullanıcının yazdığı kategori zaten varsa
            {
                return RedirectToAction("Filter", "Article", new { kategoriKontrol.ID });
            }
            if (ModelState.IsValid)
            {        
                var category = mapper.Map<Category>(dto);
                category.Statu = Statu.Passive;
                categoryRepository.Create(category);
                return RedirectToAction("List");
            }
            return View(dto);
        }


        public async Task<IActionResult> List()
        {
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser appUser = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            List<Category> followed = categoryRepository.GetCategoryWithUser(appUser.ID);
            ViewBag.takipListesi = followed.ToList();
            //Üstte Kullanıcının takip ettiği kategoriler buldundu ve viewda kullanmak üzere viewbag oluşturuldu.

            var articleList = categoryRepository.GetByDefaults
                (
                    selector: a => new GetCategoryDTO()
                    {
                        ID = a.ID,
                        Description = a.Description,
                        Name = a.Name,

                    },
                    expression: a => a.Statu != Statu.Passive

                //  ,orderby : a=>a.OrderByDescending(a=>a.CreateDate)

                );
            return View(articleList);
        }


        
        public async Task<IActionResult> Follow(int id) // category id
        {
            Category category = categoryRepository.GetDefault(a => a.ID == id);
            IdentityUser identityUser = await userManager.GetUserAsync(User);
            AppUser appUser = appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            List<Category> followed = categoryRepository.GetCategoryWithUser(appUser.ID);
            UserFollowedCategory userFollowed;

            category.UserFollowedCategories.Add(userFollowed = new UserFollowedCategory { Category = category, CategoryID = category.ID, AppUser = appUser, AppUserID = appUser.ID });
            foreach (var item in followed.ToList())
            {
                if (userFollowed.CategoryID == item.ID && userFollowed.AppUserID == appUser.ID)
                {
                    userFollowedCategoryRepository.Delete(userFollowed); 
                    return RedirectToAction("List");
                }
            }
            categoryRepository.Update(category);


            return RedirectToAction("List");


            //takip et takipten çık
        }




    }
}
