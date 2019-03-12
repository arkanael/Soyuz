using Soyuz.Application.ViewModels.Planos;
using System;
using System.Collections.Generic;

namespace Soyuz.Application.Contracts.Services
{
    public interface IPlanoApplicationService
    {
        void Cadastrar(PlanoCadastroViewModel model);
        void Alterar(PlanoEdicaoViewModel model);
        void Excluir(Guid id);
        List<PlanoConsultaViewModel> ObterTodos();
        PlanoConsultaViewModel ObterPorId(Guid id);
    }
}
