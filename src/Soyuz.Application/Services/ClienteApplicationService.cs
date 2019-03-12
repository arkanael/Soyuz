using AutoMapper;
using Soyuz.Application.Contracts.Services;
using Soyuz.Application.ViewModels.Clientes;
using Soyuz.Domain.Contracts.Services;
using Soyuz.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Soyuz.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteDomainService service;

        public ClienteApplicationService(IClienteDomainService service)
        {
            this.service = service;
        }
        
        public void Cadastrar(ClienteCadastroViewModel model)
        {
            service.Cadastrar(Mapper.Map<Cliente>(model));
        }

        public void Alterar(ClienteEdicaoViewModel model)
        {
            service.Alterar(Mapper.Map<Cliente>(model));
        }

        public void Excluir(Guid id)
        {
            service.Excluir(service.ObterPorId(id));
        }

        public ClienteConsultaViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ClienteConsultaViewModel>(service.ObterPorId(id));
        }

        public List<ClienteConsultaViewModel> ObterTodos()
        {
            return Mapper.Map<List<ClienteConsultaViewModel>>(service.ObterTodos());
        }
    }
}
