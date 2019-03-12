using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Domain.Contracts.Services;
using Soyuz.Domain.Entities;

namespace Soyuz.Domain.Services
{
    public class ClienteDomainService: BaseDomainService<Cliente>, IClienteDomainService 
    {
        private readonly IClienteRepository repository;

        public ClienteDomainService(IClienteRepository repository):base(repository)
        {
            this.repository = repository;
        }
    }
}
