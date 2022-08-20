using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Areas.Member.Views.Shared.Components.UserFollowCategory
{
    [ViewComponent(Name ="UserFollowCategory")]
    public class UserFollowCategoryViewComponent :ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        // cookiede olan kullanıcının takip ettiği categoryleri gösterelim.

        public UserFollowCategoryViewComponent(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke(int id)
        {
            var list = categoryRepository.GetCategoryWithUser(id);
            return View(list);
        }


    }
}
