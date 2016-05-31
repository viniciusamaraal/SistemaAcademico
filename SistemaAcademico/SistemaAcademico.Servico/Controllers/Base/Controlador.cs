using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Base;
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
    public class Controlador<T> : ApiController where T : Dominio.Base.Dominio
    {
        protected readonly Adaptador adaptador;

        public Controlador()
        {
            this.adaptador = new Adaptador();
        }

        public Controlador(Adaptador adaptador)
        {
            this.adaptador = adaptador;
        }

        private Gerenciador<T> _gerenciador;
        protected Gerenciador<T> Gerenciador
        {
            get
            {
                if (_gerenciador == null)
                {
                    var propriedades = typeof(Adaptador).GetProperties();
                    foreach (PropertyInfo i in propriedades)
                    {
                        var tipo = i.PropertyType;
                        // TODO: Verificar forma melhor de buscar o tipo da propriedade:
                        if (tipo.BaseType.GenericTypeArguments.Any() &&
                            tipo.BaseType.GenericTypeArguments[0].FullName == typeof(T).FullName)
                        {
                            _gerenciador = i.GetValue(adaptador) as Gerenciador<T>;
                            break;
                        }
                    }
                }

                return _gerenciador;
            }
        }

        // GET: api/Entidade
        [HttpGet]
        public IEnumerable<T> Buscar()
        {
            return Gerenciador.Buscar();
        }

        // GET: api/Entidade/5
        [HttpGet]
        public IHttpActionResult Buscar(int id)
        {
            var entidade = Gerenciador.Buscar(id);
            if (entidade == null)
                return NotFound();

            return Ok(entidade);
        }

        // PUT: api/Entidade/5
        [HttpPut]
        public IHttpActionResult Editar(int id, T entidade)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != entidade.Id)
                return BadRequest();

            Gerenciador.Editar(entidade);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Entidade
        [HttpPost]
        public IHttpActionResult Inserir(T entidade)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Gerenciador.Inserir(entidade);
            // TODO: Verificar forma de não deixar rota chapada:
            return CreatedAtRoute("DefaultApi", new { id = entidade.Id }, entidade);
        }

        // DELETE: api/Entidade/5
        [HttpDelete]
        public IHttpActionResult Excluir(int id)
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
                Gerenciador.Dispose();

            base.Dispose(disposing);
        }
    }
}
