using System;
using System.ComponentModel.DataAnnotations;

namespace Soyuz.Application.ViewModels.Clientes
{
    public class ClienteCadastroViewModel
    {
        [MaxLength(60, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(4, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [MaxLength(70, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(4, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo IdPlano é obrigatório.")]
        public Guid IdPlano { get; set; }
    }
}
