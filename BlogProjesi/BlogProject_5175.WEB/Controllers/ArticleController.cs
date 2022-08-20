using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using BlogProject_5175.Models.Enums;
using BlogProject_5175.WEB.Areas.Member.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Controllers
{
    public class ArticleController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IArticleRepository articleRepository;
        private readonly IAppUserRepository appUserRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ICommentRepository commentRepository;
        private readonly ILikeRepository likeRepository;
        private readonly IArticleCategoryRepository articleCategoryRepository;

        public ArticleController(UserManager<IdentityUser> userManager, IArticleRepository articleRepository, IAppUserRepository appUserRepository,
            ICategoryRepository categoryRepository, ICommentRepository commentRepository, ILikeRepository likeRepository,IArticleCategoryRepository articleCategoryRepository)
        {
            this.userManager = userManager;
            this.articleRepository = articleRepository;
            this.appUserRepository = appUserRepository;
            this.categoryRepository = categoryRepository;
            this.commentRepository = commentRepository;
            this.likeRepository = likeRepository;
            this.articleCategoryRepository = articleCategoryRepository;
        }

        public IActionResult Detail(Article dto)
        {
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
            //üstte articlenin gerekli bilgilerini repositoryden aldık

            ViewBag.begenmeSayisi = article.Likes.Count; //makaleyi kaç kişinin beğendiği bilgisi viewbag olarak tutuldu

            foreach (var item in article.Comments) //hangi yorumun hangi kullanıcıya ait olduğu bulunuyor.
            {
                item.AppUser = appUserRepository.GetDefault(a => a.ID == item.AppUserID);
            }

            var kelimeSayisi = article.Content.Count(x => x == ' ') + 1;
            ViewBag.okunmaSuresi = (kelimeSayisi / 100) * 2;



            return View(article);
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
    }
}
