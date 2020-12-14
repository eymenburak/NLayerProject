using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
   public  interface IRepository<TEntity> where TEntity:class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate); //Find(x=>x.id==Id);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate); //category.SingleOrDefaultAsync(x=>x.Name == "Pen");
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);

    }
}
