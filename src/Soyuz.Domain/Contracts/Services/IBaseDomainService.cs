using System;
using System.Collections.Generic;

namespace Soyuz.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity> where TEntity : class
    {
        void Cadastrar(TEntity entity);
        void Alterar(TEntity entity);
        void Excluir(TEntity entity);
        List<TEntity> ObterTodos();
        TEntity ObterPorId(Guid id);
    }
}
