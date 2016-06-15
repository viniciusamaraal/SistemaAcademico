using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Excecao.Dado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SistemaAcademico.Servico.Controllers.Base
{
    public class Controlador : ApiController
    {
        protected readonly Adaptador adaptador;

        public Controlador()
        {
            this.adaptador = new Adaptador(RegistraErros);
        }

        public Controlador(Adaptador adaptador)
        {
            this.adaptador = adaptador;
        }

        protected void RegistraErros(string chave, string erro)
        {
            ModelState.AddModelError(chave, erro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                adaptador.Dispose();

            base.Dispose(disposing);
        }
    }
}
