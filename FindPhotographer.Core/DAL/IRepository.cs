using FindPhotographer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Core.DAL
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity //entity tipinde class tarafından implement edilebilir
    {
        //crud işlemleri için kullanılan en temel yapı
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter);

        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
