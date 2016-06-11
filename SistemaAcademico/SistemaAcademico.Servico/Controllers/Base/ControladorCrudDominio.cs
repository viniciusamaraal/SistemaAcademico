using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaAcademico.Servico.Controllers.Base
{
    public class ControladorCrudDominio<TDominio> : ControladorCrud<TDominio> where TDominio : Dominio.Base.Dominio
    {
        public ControladorCrudDominio() : base()
        {
        }

        public ControladorCrudDominio(Adaptador adaptador) : base(adaptador)
        {
        }

        // PUT: api/Entidade/5
        //[HttpPut]
        public virtual IHttpActionResult Editar(int id, TDominio entidade)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != entidade.Id)
                return BadRequest();

            if (Gerenciador.Editar(entidade))
                return StatusCode(HttpStatusCode.NoContent);
            return BadRequest(ModelState);
        }

        // POST: api/Entidade
        [HttpPost]
        public virtual IHttpActionResult Inserir(TDominio entidade)
        {
            if (!ModelState.IsValid && Gerenciador.Inserir(entidade))
            {
                // TODO: Verificar forma de não deixar rota chapada:
                return CreatedAtRoute("DefaultApi", new { id = entidade.Id }, entidade);
            }
            return BadRequest(ModelState);
        }
    }
}
