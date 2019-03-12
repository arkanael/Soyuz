using AutoMapper;
using Soyuz.Application.ViewModels.Clientes;
using Soyuz.Application.ViewModels.Planos;
using Soyuz.Domain.Entities;
using System;

namespace Soyuz.Application.Mappings
{
    public class AutoMapperMap : Profile
    {
        public AutoMapperMap()
        {
            CreateMap<PlanoCadastroViewModel, Plano>()
                .AfterMap((src, dest) => dest.Id = Guid.NewGuid());

            CreateMap<PlanoEdicaoViewModel, Plano>();

            CreateMap<Plano, PlanoConsultaViewModel>();

            CreateMap<ClienteCadastroViewModel, Cliente>()
                .AfterMap((src, dest) => dest.Id = Guid.NewGuid());

            CreateMap<ClienteEdicaoViewModel, Cliente>();
            CreateMap<Cliente, ClienteConsultaViewModel>();
        }
    }
}
