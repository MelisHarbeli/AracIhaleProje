using AracIhaleProje.Api.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AracIhaleProje.Api.DAL.İhaleEkleDAL
{
    public class IhaleRepoBase<TEntity, Tcontext> : IEntityRepository<TEntity>
    where TEntity : class, new()
   where Tcontext : DbContext, new()
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using (var context = new Tcontext())
            {
              
                var added =  await context.Set<TEntity>().AddAsync(entity);
                added.State = EntityState.Added;
                var deger = context.SaveChanges();
               
            }
            return entity;
        }

        //public void Delete(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new Tcontext())
            {
                return filter == null
                    ? db.Set<TEntity>().ToList()
                    : db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            
            
                List<TEntity> entities;
                using (var context = new Tcontext())
                {
                    entities = await context.Set<TEntity>().AsNoTracking().ToListAsync();
                }
                return entities;
            

        }

        public async Task UpdateAsync(TEntity entity)
        {
           
            throw new NotImplementedException();
        }
        public async Task RemoveAsync(TEntity entity)
        {
           
            throw new NotImplementedException();

        }
    }
}
