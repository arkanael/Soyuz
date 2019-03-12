using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Soyuz.Infra.Repository.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext context;

        protected BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public void Insert(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity FindById(Guid id)
        {
            return context.Set<TEntity>().Find(id);
        }
        
    }
}
