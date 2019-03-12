using Soyuz.Application.ViewModels.Clientes;
using System;
using System.Collections.Generic;

namespace Soyuz.Application.Contracts.Services
{
    public interface IClienteApplicationService
    {
        void Cadastrar(ClienteCadastroViewModel model);
        void Alterar(ClienteEdicaoViewModel model);
        void Excluir(Guid id);
        List<ClienteConsultaViewModel> ObterTodos();
        ClienteConsultaViewModel ObterPorId(Guid id);
    }
}
