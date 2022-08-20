using BlogProject_5175.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject_5175.DAL.Repositories.Interfaces.Concrete
{
    public interface IPreviousPasswordRepository
    {
        void Create(PreviousPassword entity);

        void Delete(PreviousPassword entity);

        PreviousPassword GetDefault(Expression<Func<PreviousPassword, bool>> expression);

        List<PreviousPassword> GetDefaults(Expression<Func<PreviousPassword, bool>> expression);
    }
}
