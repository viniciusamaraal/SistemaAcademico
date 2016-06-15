using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Servico.Dto.Base;
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
    public class ControladorCrudDto<TDominio, TDto> : ControladorCrud<TDominio> where TDominio : Dominio.Base.Dominio where TDto : DtoDominio<TDominio>, new()
    {
        public ControladorCrudDto() : base()
        {
        }

        public ControladorCrudDto(Adaptador adaptador) : base(adaptador)
        {
        }

        private static TDto CriarDto(TDominio rf)
        {
            var dto = new TDto();
            dto.ConstruirDto(rf);
            return dto;
        }

        public override IHttpActionResult Buscar()
        {
            return Ok(Gerenciador.Buscar().Select(rf => CriarDto(rf)).ToList());
        }

        public override IHttpActionResult Buscar(int id)
        {
            var entidade = Gerenciador.Buscar(id);
            if (entidade == null)
                return NotFound();

            return Ok(CriarDto(entidade));
        }

        // PUT: api/Entidade/5
        [HttpPut]
        public virtual IHttpActionResult Editar(int id, TDto entidade)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dominio = entidade.ConstruirDominio();

            if (id != dominio.Id)
                return BadRequest();

            if (Gerenciador.Editar(dominio))
                return StatusCode(HttpStatusCode.NoContent);
            return BadRequest(ModelState);
        }

        // POST: api/Entidade
        [HttpPost]
        public virtual IHttpActionResult Inserir(TDto entidade)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dominio = entidade.ConstruirDominio();

            if (Gerenciador.Inserir(dominio))
            {
                // TODO: Verificar forma de não deixar rota chapada:
                return CreatedAtRoute("DefaultApi", new { id = entidade.Id }, entidade);
            }
            return BadRequest(ModelState);
        }
    }
}
