using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Domain.Contracts.Services;
using System;
using System.Collections.Generic;

namespace Soyuz.Domain.Services
{
    public abstract class BaseDomainService<TEntity> : IBaseDomainService<TEntity> where TEntity : class
    {       
        private readonly IBaseRepository<TEntity> repository;

        protected BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }
        
        public virtual void Cadastrar(TEntity entity)
        {
            repository.Insert(entity);
        }
        
        public virtual void Alterar(TEntity entity)
        {
            repository.Update(entity);
        }

        /// <summary>
        /// Deleta um dado na base de dados.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Excluir(TEntity entity)
        {
            repository.Delete(entity);
        }
        
        public virtual List<TEntity> ObterTodos()
        {
            return repository.FindAll();
        }
        
        public virtual TEntity ObterPorId(Guid id)
        {
            return repository.FindById(id);
        }
    }
}
