using FindPhotographer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Core.DAL.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        TContext tcontext = EFSingletonContext<TContext>.Instance;

        public void Add(TEntity entity)
        {
            tcontext.Entry(entity).State = EntityState.Added;
            tcontext.SaveChanges();
        }
        
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return tcontext.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter==null)
            {
                return tcontext.Set<TEntity>().ToList();
            }
            else
            {
                return tcontext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Remove(TEntity entity)
        {
            tcontext.Entry(entity).State = EntityState.Deleted;
            tcontext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            tcontext.Entry(entity).State = EntityState.Modified;
            tcontext.SaveChanges();
        }
    }
}
