using Soyuz.Application.ViewModels.Planos;
using System;

namespace Soyuz.Application.ViewModels.Clientes
{
    public class ClienteConsultaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid IdPlano { get; set; }
    }
}
