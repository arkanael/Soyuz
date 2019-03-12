using AutoMapper;
using Soyuz.Application.Contracts.Services;
using Soyuz.Application.ViewModels.Planos;
using Soyuz.Domain.Contracts.Services;
using Soyuz.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Soyuz.Application.Services
{
    public class PlanoApplicationService : IPlanoApplicationService
    {
        private readonly IPlanoDomainService service;

        public PlanoApplicationService(IPlanoDomainService service)
        {
            this.service = service;
        }

        public void Cadastrar(PlanoCadastroViewModel model)
        {
            service.Cadastrar(Mapper.Map<Plano>(model));
        }

        public void Alterar(PlanoEdicaoViewModel model)
        {
            service.Alterar(Mapper.Map<Plano>(model));
        }

        public void Excluir(Guid id)
        {
            service.Excluir(Mapper.Map<Plano>(id));
        }

        public PlanoConsultaViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<PlanoConsultaViewModel>(service.ObterPorId(id));
        }

        public List<PlanoConsultaViewModel> ObterTodos()
        {
            return Mapper.Map<List<PlanoConsultaViewModel>>(service.ObterTodos());
        }
    }
}
