using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyuz.Domain.Contracts.Repositories
{
    /// <summary>
    /// Interface para operações genericas de acesso a base de dados.
    /// </summary>
    /// <typeparam name="TEntity">Entidade Generica que é tipada como uma classe</typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Inserir um dado na base
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Atualiza um dado na base.
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Deleta um dado na base.
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// Lista todos os dados na base.
        /// </summary>
        /// <returns>Entidades</returns>
        List<TEntity> FindAll();

        /// <summary>
        /// Lista um dado na base buscando pelo Id
        /// </summary>
        /// <param name="id">Identificador do dado</param>
        /// <returns>Entidade</returns>
        TEntity FindById(Guid id);
    }
}
