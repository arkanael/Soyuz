using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using Soyuz.Application.Contracts.Services;
using Soyuz.Application.Mappings;
using Soyuz.Application.Services;
using Soyuz.Domain.Contracts.Repositories;
using Soyuz.Domain.Contracts.Services;
using Soyuz.Domain.Services;
using Soyuz.Infra.Repository.Context;
using Soyuz.Infra.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Soyuz.Presentation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AutoMapperConfig.Register();

            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            container.Register<IPlanoApplicationService, PlanoApplicationService>(Lifestyle.Scoped);
            container.Register<IClienteApplicationService, ClienteApplicationService>(Lifestyle.Scoped);

            container.Register<IPlanoDomainService, PlanoDomainService>(Lifestyle.Scoped);
            container.Register<IClienteDomainService, ClienteDomainService>(Lifestyle.Scoped);

            container.Register<IPlanoRepository, PlanoRepository>(Lifestyle.Scoped);
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);

            container.Register<DataContext>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader
            ("Access-Control-Allow-Origin", "*");

            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader
            ("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");

                HttpContext.Current.Response.AddHeader
            ("Access-Control-Allow-Headers", "Content-Type, Accept");
                HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");

                HttpContext.Current.Response.End();
            }
        }
    }
}
