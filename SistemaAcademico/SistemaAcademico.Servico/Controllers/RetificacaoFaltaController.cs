using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.DTO;
using SistemaAcademico.Negocio.Gerenciador;
using SistemaAcademico.Servico.Controllers.Base;
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
            // TODO: Procurar uma forma melhor de fazer sem precisar de dar cast Gerenciador e/ou no Repositório.
            return Content(HttpStatusCode.OK, ((GerenciadorRetificacaoFalta)Gerenciador).Buscar());
        }
    }
}
