using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.WEB.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace BlogProject_5175.WEB.Views.Shared.Components.Articles
{
    [ViewComponent(Name ="Articles")]
    public class ArticlesViewComponent : ViewComponent
    {

        // oluşma tarihine göre güncel 10 makalaeyi göstereceğiz.

        private readonly IArticleRepository articleRepository;
        public ArticlesViewComponent(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public IViewComponentResult Invoke()
        {
            List<GetArticleWithUserVM> articles = articleRepository.GetByDefaults
                (
                 selector:a=> new GetArticleWithUserVM()
                 {
                    Title=a.Title,
                    Content=a.Content,
                    UserId=a.AppUser.ID,
                    UserFullName=a.AppUser.FullName,
                    ArticleId=a.ID,
                    Image=a.Image,
                    CreatedDate=a.CreateDate,
                    CategoryName=a.Category.Name
                 },
                 expression: a=>a.Statu!=Statu.Passive && a.Category.Statu !=Statu.Passive,
                 include: a=>a.Include(a=>a.AppUser).Include(a=>a.Category),
                 orderby: a=>a.OrderByDescending(a=>a.CreateDate)
                );

            return View(articles.Take(10).ToList());


        }


    }
}
