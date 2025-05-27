using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AdiantamentoController : ApiController
    {
  
        [HttpPost]
        [Route("01CriarAntecipacao")]
        public IHttpActionResult CriarAntecipacaoCriarAntecipacao()
        {
            return null;
        }
        
        [HttpGet]
        [Route("02ConsultarSolicitacao")]
        public IHttpActionResult ConsultarSolicitacao()
        {
            return null;
        }
        
        [HttpGet]
        [Route("03ListarSolicitacoes")]
        public IHttpActionResult ListarSolicitacoes()
        {
            return null;
        }

        [HttpPut]
        [Route("04AprovarSolicitacoes")]
        public void AprovarSolicitacoes()
        {
        }

       
    }
}
