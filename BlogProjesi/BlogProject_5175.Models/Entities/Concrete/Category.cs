using BlogProject_5175.Models.Entities.Abstract;
using System.Collections.Generic;

namespace BlogProject_5175.Models.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Articles = new List<Article>();
            UserFollowedCategories = new List<UserFollowedCategory>();
            ArticleCategories = new List<ArticleCategory>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        // NAVİGATION PROPERTY

        // 1 kategorinin çokça makales olabilir.

        public List<Article> Articles { get; set; }

        //1 kategorinin çokça takip edeni olabilir.

        public List<UserFollowedCategory>  UserFollowedCategories { get; set; }

        public List<ArticleCategory> ArticleCategories { get; set; }

    }
}