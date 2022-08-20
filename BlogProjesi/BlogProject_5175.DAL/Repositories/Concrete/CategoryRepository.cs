using BlogProject_5175.DAL.Context;
using BlogProject_5175.DAL.Repositories.Abstract;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using BlogProject_5175.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogProject_5175.DAL.Repositories.Concrete
{
   public class CategoryRepository :BaseRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(ProjectContext context):base(context)
        {

        }

        //kullanıcın takip ettiği kategorileri alan componentte kullanacağımız metot

        public List<Category> GetCategoryWithUser(int id)
        {
            return context.FollowedCategories.Include(a => a.AppUser).Include(a => a.Category).Where(a => a.AppUserID == id && a.Category.Statu !=Statu.Passive).Select(a => a.Category).ToList();
        }



    }
}
