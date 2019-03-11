using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyuz.Domain.Entities
{
    public class Plano
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}
