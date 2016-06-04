using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador;
using SistemaAcademico.Servico.Controllers.Base;
using SistemaAcademico.Servico.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaAcademico.Servico.Controllers
{
    public class RetificacaoFaltaController : ControladorCrud<RetificacaoFalta>
    {
        public override IHttpActionResult Buscar()
        {
            return Content(HttpStatusCode.OK, Gerenciador.Buscar().Select(rf => new RetificacaoFaltaDTO(rf)));
        }


    }
}
