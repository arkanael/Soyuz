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
            
        }
    }
}
