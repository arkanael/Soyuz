using Soyuz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyuz.Domain.Contracts.Repositories
{
    /// <summary>
    /// Interface para operações de clientes de acesso a base de dados, implenta o repositorio IBaseRepository tipado para cliente
    /// </summary>
    public interface IClienteRepository : IBaseRepository<Cliente>
    {

    }
}
