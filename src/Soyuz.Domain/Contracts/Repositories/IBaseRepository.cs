using System;
using System.Collections.Generic;

namespace Soyuz.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
       
        void Insert(TEntity entity);
       
        void Update(TEntity entity);
        
        void Delete(TEntity entity);
        
        List<TEntity> FindAll();
        
        TEntity FindById(Guid id);
    }
}
