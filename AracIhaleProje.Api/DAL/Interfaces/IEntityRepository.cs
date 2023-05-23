using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AracIhaleProje.Api.DAL.Interfaces
{
    public interface IEntityRepository<TEntity>
      where TEntity : class, new()
    {
        Task<TEntity> AddAsync(TEntity entity);
        //void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}
