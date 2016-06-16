using SistemaAcademico.Dominio;
using SistemaAcademico.Servico.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaAcademico.Servico.Controllers
{
    public class GradesController : ControladorCrudDominio<GradeDisciplina>
    {
        public override IHttpActionResult Buscar()
        {
            return Ok(Gerenciador.Buscar().GroupBy(gd => gd.Grade).Select(gd => gd.Key).ToList());
        }
    }
}
