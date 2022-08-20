using BlogProject_5175.DAL.Context;
using BlogProject_5175.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogProject_5175.DAL.Repositories.Concrete
{
    public class UserFollowedCategoryRepository : IUserFollowedCategoryRepository
    {
        private readonly ProjectContext context;
        private readonly DbSet<UserFollowedCategory> _table;

        public UserFollowedCategoryRepository(ProjectContext context)
        {
            this.context = context;
            _table = context.Set<UserFollowedCategory>();
        }

        public void Create(UserFollowedCategory entity)
        {
            _table.Add(entity);
            context.SaveChanges();
        }

        public void Delete(UserFollowedCategory entity)
        {          
            _table.Remove(entity);
            context.SaveChanges();
        }
    }
}
