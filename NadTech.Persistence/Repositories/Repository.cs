using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NadTech.Core.Repositories;
using NadTech.Data;

namespace NadTech.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly NadTechCustomerDbContext Context;

        public Repository(NadTechCustomerDbContext context)
        {
            Context = context;
        }

        public async Task<TEntity> GetAsync(int id)  
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public TEntity Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            return entity;
        }

        public int AddRange(IEnumerable<TEntity> entities)
        {
            var enumerable = entities.ToList();
            Context.Set<TEntity>().AddRange(enumerable);
            return enumerable.Count();  
        }

        public TEntity Update(int id, TEntity entity)
        {
            var existingEntity = Context.Set<TEntity>().Find(id);
            Context.Entry(existingEntity).CurrentValues.SetValues(entity);

            return entity;
        }

        public TEntity UpdateByGuid(Guid id, TEntity entity)
        {
            var existingEntity = Context.Set<TEntity>().Find(id);
            Context.Entry(existingEntity).CurrentValues.SetValues(entity);

            return entity;
        }

        public int Count()
        {
            return Context.Set<TEntity>().Count();
        }

        public bool Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            return true;
        }

        public int RemoveRange(IEnumerable<TEntity> entities)
        {
            var enumerable = entities.ToList();
            Context.Set<TEntity>().RemoveRange(enumerable);
            return enumerable.Count();
        }

        public bool IsExist(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Any(predicate);
        }
    }
}
