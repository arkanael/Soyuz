using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Domain.Contracts.Services;
using Soyuz.Domain.Entities;

namespace Soyuz.Domain.Services
{
    public class PlanoDomainService : BaseDomainService<Plano>, IPlanoDomainService
    {
        private readonly IPlanoRepository repository;

        public PlanoDomainService(IPlanoRepository repository):base(repository)
        {
            this.repository = repository;
        }
    }
}
