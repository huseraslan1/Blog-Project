using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Controllers
{
    public class AppUserController : Controller
    {
        private readonly IAppUserRepository appUserRepository;
        private readonly IArticleRepository articleRepository;
        private readonly ICommentRepository commentRepository;

        public AppUserController(IAppUserRepository appUserRepository,IArticleRepository articleRepository, ICommentRepository commentRepository)
        {

            this.appUserRepository = appUserRepository;
            this.articleRepository = articleRepository;
            this.commentRepository = commentRepository;
        }

        public IActionResult UserDetail(int id)
        {

            AppUser author = appUserRepository.GetDefault(a => a.ID == id);
            author.Articles = articleRepository.GetDefaults(a => a.AppUserID == author.ID);
            author.Comments = commentRepository.GetDefaults(a => a.AppUserID == author.ID);

            foreach (var item in author.Comments) //hangi yorumun hangi makaleye ait olduğu bulunuyor.
            {
                item.Article = articleRepository.GetDefault(a => a.ID == item.ArticleID);
            }
            return View(author);
        }
    }
}
