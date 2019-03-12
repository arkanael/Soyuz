using Soyuz.Application.Contracts.Services;
using Soyuz.Application.ViewModels.Clientes;
using Soyuz.Presentation.Utilitarios;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Soyuz.Presentation.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        private readonly IClienteApplicationService service;

        public ClienteController(IClienteApplicationService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Cadastrar(model);
                    return Request.CreateResponse(HttpStatusCode.OK, "O plano foi excluido com sucesso.");
                }
                catch (Exception erro)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, erro.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ValidationsUtil.GetErrorMessages(ModelState));
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage PUT(ClienteEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Alterar(model);

                    return Request.CreateResponse(HttpStatusCode.OK, $"O cliente {model.Nome} foi atualizado com sucesso.");
                }
                catch (Exception erro)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, erro.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ValidationsUtil.GetErrorMessages(ModelState));
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                var plano = service.ObterPorId(id);

                if (plano != null)
                {
                    service.Excluir(id);

                    return Request.CreateResponse(HttpStatusCode.OK, "O plano foi excluido com sucesso.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Plano não encontrado.");
                }
            }
            catch (Exception erro)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpGet]
        [Route("consultar")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, service.ObterTodos());
            }
            catch (Exception erro)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpGet]
        [Route("obterporid")]
        public HttpResponseMessage GetById(Guid id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, service.ObterPorId(id));
            }
            catch (Exception erro)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}

