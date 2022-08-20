using BlogProject_5175.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject_5175.DAL.Repositories.Interfaces.Concrete
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategory entity);

        void Delete(ArticleCategory entity);

        ArticleCategory GetDefault(Expression<Func<ArticleCategory, bool>> expression);

        List<ArticleCategory> GetDefaults(Expression<Func<ArticleCategory, bool>> expression);
    }
}
