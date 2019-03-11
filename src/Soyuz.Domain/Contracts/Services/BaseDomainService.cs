using Soyuz.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyuz.Domain.Contracts.Services
{
    public abstract class BaseDomainService<TEntity> where TEntity : class
    {
        /// <summary>
        /// Atributo privado e somente leitura para acesso ao repositório via injeção de dependência.
        /// </summary>
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
