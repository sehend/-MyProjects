using Core.Model;
using Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccess
{
    public class RepositoryBase<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new Context())
            {
                var AddEntity =  context.Entry(entity);

                AddEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new Context())
            {
                var AddEntity = context.Entry(entity);

                AddEntity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new Context())
            {
               return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return filter == null 

                    ? context.Set<TEntity>().ToList() 

                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new Context())
            {
                var AddEntity = context.Entry(entity);

                AddEntity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}

