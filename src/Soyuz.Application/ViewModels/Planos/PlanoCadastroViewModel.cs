using System.ComponentModel.DataAnnotations;

namespace Soyuz.Application.ViewModels.Planos
{
    public class PlanoCadastroViewModel
    {
        [MaxLength(30, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(4, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        public string Descricao { get; set; }
    }
}
