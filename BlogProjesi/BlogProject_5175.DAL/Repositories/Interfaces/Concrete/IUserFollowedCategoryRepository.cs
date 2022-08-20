using BlogProject_5175.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject_5175.DAL.Repositories.Interfaces.Concrete
{
   public interface IUserFollowedCategoryRepository
    {
        void Create(UserFollowedCategory entity);

      
        void Delete(UserFollowedCategory entity);

        

    }
}
