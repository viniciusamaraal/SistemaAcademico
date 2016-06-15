using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Excecao.Dado;
using SistemaAcademico.Util.Reflexao;
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
    public class ControladorCrud<TDominio> : Controlador where TDominio : Dominio.Base.Dominio
    {
        public ControladorCrud() : base()
        {
        }

        public ControladorCrud(Adaptador adaptador) : base(adaptador)
        {
        }

        private GerenciadorDominio<TDominio> _gerenciador;
        protected GerenciadorDominio<TDominio> Gerenciador
        {
            get
            {
                if (_gerenciador == null)
                {
                    _gerenciador = adaptador.BuscarPropriedade<GerenciadorDominio<TDominio>>();

                    if (_gerenciador == null)
                        throw new NotImplementedException("Gerenciador não encontrado para o tipo " + typeof(TDominio).FullName);
                }

                return _gerenciador;
            }
        }

        // GET: api/Entidade
        [HttpGet]
        public virtual IHttpActionResult Buscar()
        {
            return Ok(Gerenciador.Buscar().ToList());
        }

        // GET: api/Entidade/5
        [HttpGet]
        public virtual IHttpActionResult Buscar(int id)
        {
            var entidade = Gerenciador.Buscar(id);
            if (entidade == null)
                return NotFound();

            return Ok(entidade);
        }

        // DELETE: api/Entidade/5
        [HttpDelete]
        public virtual IHttpActionResult Excluir(int id)
        {
            var entidade = Gerenciador.Buscar(id);
            if (entidade == null)
                return NotFound();

            Gerenciador.Excluir(id);

            return Ok(entidade);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _gerenciador?.Dispose();

            base.Dispose(disposing);
        }
    }
}
