using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyuz.Domain.Services
{
    public class PlanoDomainService : BaseDomainService<Plano>
    {
        private readonly IPlanoRepository repository;

        public PlanoDomainService(IPlanoRepository repository):base(repository)
        {
            this.repository = repository;
        }
    }
}
