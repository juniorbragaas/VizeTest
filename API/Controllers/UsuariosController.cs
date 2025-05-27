using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UsuariosController : ApiController
    {
  
        [HttpPost]
        [Route("01Criar")]
        public IHttpActionResult CriarAntecipacaoCriarAntecipacao()
        {
            return null;
        }
        
        [HttpGet]
        [Route("02Consultar")]
        public IHttpActionResult ConsultarUsuarios()
        {
            return null;
        }
        
        [HttpGet]
        [Route("03Autenticar")]
        public IHttpActionResult AutenticarUsuarios()
        {
            return null;
        }

        [HttpPost]
        [Route("04Aterar")]
        public IHttpActionResult AterarUsuarios()
        {
            return null;
        }

        [HttpGet]
        [Route("05Listar")]
        public void ListarUsuarios()
        {
        }

       
    }
}
