using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyuz.Domain.Services
{
    public abstract class BaseDomainService<TEntity> where TEntity : class
    {
        public virtual void Cadastrar(TEntity entity)
        {
            throw new NotImplementedException(); //TODO..
        }

        public virtual void Alterar(TEntity entity)
        {
            throw new NotImplementedException(); //TODO..
        }

        public virtual void Excluir(TEntity entity)
        {
            throw new NotImplementedException(); //TODO..
        }

        public virtual List<TEntity> ObterTodos()
        {
            throw new NotImplementedException(); //TODO..
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            throw new NotImplementedException(); //TODO..
        }
    }
}
