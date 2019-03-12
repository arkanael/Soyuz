using System;

namespace Soyuz.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid IdPlano { get; set; }

        public Plano Plano { get; set; }
    }
}
