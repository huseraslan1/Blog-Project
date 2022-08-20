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
    public class PreviousPasswordRepository : IPreviousPasswordRepository
    {
        private readonly ProjectContext context;
        private readonly DbSet<PreviousPassword> _table;

        public PreviousPasswordRepository(ProjectContext context)
        {
            this.context = context;
            _table = context.Set<PreviousPassword>();
        }
        public void Create(PreviousPassword entity)
        {
            _table.Add(new PreviousPassword()
            {               
                AppuserID = entity.AppuserID,
                PPassword = entity.PPassword,
                ChangeDate = entity.ChangeDate
            });

            context.SaveChanges();
        }

        public void Delete(PreviousPassword entity)
        {           
            PreviousPassword silinecekEntity = context.PreviousPasswords.Single(a => a.AppuserID == entity.AppuserID && a.PPassword == entity.PPassword);            
            _table.Remove(silinecekEntity);
            context.SaveChanges();
        }

        public PreviousPassword GetDefault(Expression<Func<PreviousPassword, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public List<PreviousPassword> GetDefaults(Expression<Func<PreviousPassword, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }
    }
}
