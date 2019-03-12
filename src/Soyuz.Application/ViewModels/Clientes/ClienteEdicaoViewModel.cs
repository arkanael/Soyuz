using System;
using System.ComponentModel.DataAnnotations;

namespace Soyuz.Application.ViewModels.Clientes
{
    public class ClienteEdicaoViewModel
    {
        [Required(ErrorMessage = "O campo Id é obrigatório.")]
        public Guid Id { get; set; }

        [MaxLength(60, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(4, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [MaxLength(70, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(4, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo IdPlano é obrigatório.")]
        public Guid IdPlano { get; set; }
    }
}
