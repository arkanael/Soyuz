using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Domain.Entities;
using Soyuz.Infra.Repository.Context;

namespace Soyuz.Infra.Repository.Repositories
{
    public class PlanoRepository : BaseRepository<Plano>, IPlanoRepository
    {
        private readonly DataContext context;

        public PlanoRepository(DataContext context):base(context)
        {
            this.context = context;
        }
    }
}
