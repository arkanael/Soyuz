using System;
using System.ComponentModel.DataAnnotations;

namespace Soyuz.Application.ViewModels.Planos
{
    public class PlanoEdicaoViewModel
    {
        [Required(ErrorMessage = "O campo Id é obrigatório.")]
        public Guid Id { get; set; }

        [MaxLength(30, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(4, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        public string Descricao { get; set; }

    }
}
