using BlogProject_5175.DAL.Context;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject_5175.DAL.Repositories.Concrete
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly ProjectContext context;
        private readonly DbSet<ArticleCategory> _table;

        public ArticleCategoryRepository(ProjectContext context)
        {
            this.context = context;
            _table = context.Set<ArticleCategory>();
        }
        public void Create(ArticleCategory entity)
        {
            _table.Add(new ArticleCategory()
            {
                Article = null,
                Category = entity.Category,
                ArticleID = entity.ArticleID,
                CategoryID = entity.CategoryID

            });
            context.SaveChanges();
        }

        public void Delete(ArticleCategory entity)
        {
            ArticleCategory silinecekEntity = context.ArticleCategories.Single(a => a.CategoryID == entity.CategoryID && a.ArticleID == entity.ArticleID);
            _table.Remove(silinecekEntity);
            context.SaveChanges();
        }

        public ArticleCategory GetDefault(Expression<Func<ArticleCategory, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public List<ArticleCategory> GetDefaults(Expression<Func<ArticleCategory, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }
    }
}
