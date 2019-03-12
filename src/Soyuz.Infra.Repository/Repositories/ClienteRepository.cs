using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Domain.Entities;
using Soyuz.Infra.Repository.Context;

namespace Soyuz.Infra.Repository.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DataContext context;

        public ClienteRepository(DataContext context):base(context)
        {
            this.context = context;
        }
    }
}
