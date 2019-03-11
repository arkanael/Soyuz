using Soyuz.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyuz.Domain.Services
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

        /// <summary>
        /// Cadastra um dado na base de dados.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Cadastrar(TEntity entity)
        {
            repository.Insert(entity);
        }

        /// <summary>
        /// Atualiza um dado na base de dados.
        /// </summary>
        /// <param name="entity"></param>
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

        /// <summary>
        /// Obtem todos os dados da base
        /// </summary>
        /// <returns></returns>
        public virtual List<TEntity> ObterTodos()
        {
            return repository.FindAll();
        }

        /// <summary>
        /// Obtem um dado na base de dados pelo Id.
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns></returns>
        public virtual TEntity ObterPorId(Guid id)
        {
            return repository.FindById(id);
        }
    }
}
