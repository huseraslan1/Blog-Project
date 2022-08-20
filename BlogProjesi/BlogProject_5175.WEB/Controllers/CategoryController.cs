using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Enums;
using BlogProject_5175.WEB.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IAppUserRepository appUserRepository;

        public CategoryController(ICategoryRepository categoryRepository, IAppUserRepository appUserRepository)
        {
            this.categoryRepository = categoryRepository;
            this.appUserRepository = appUserRepository;
        }

        public IActionResult List()
        {
            var articleList = categoryRepository.GetByDefaults
                (
                    selector: a => new GetCategoryDTO()
                    {
                        ID = a.ID,
                        Description = a.Description,
                        Name = a.Name,

                    },
                    expression: a => a.Statu != Statu.Passive
                );
            return View(articleList);
        }
    }
}
