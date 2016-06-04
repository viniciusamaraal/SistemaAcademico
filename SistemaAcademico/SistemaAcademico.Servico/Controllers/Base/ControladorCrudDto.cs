using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Servico.Models.Dto.Base;
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
    public class ControladorCrudDto<TDominio, TDto> : ControladorCrud<TDominio> where TDominio : Dominio.Base.Dominio where TDto : Dto<TDominio>
    {
        public ControladorCrudDto() : base()
        {
        }

        public ControladorCrudDto(Adaptador adaptador) : base(adaptador)
        {
        }


        // PUT: api/Entidade/5
        //[HttpPut]
        //public override IHttpActionResult Editar(int id, TDto entidade)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var dominio = entidade.Constroi();

        //    if (id != dominio.Id)
        //        return BadRequest();

        //    Gerenciador.Editar(dominio);
        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Entidade
        //[HttpPost]
        //public override IHttpActionResult Inserir(TDto entidade)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var dominio = entidade.Constroi();

        //    Gerenciador.Inserir(dominio);
        //    // TODO: Verificar forma de não deixar rota chapada:
        //    return CreatedAtRoute("DefaultApi", new { id = entidade.Id }, entidade);
        //}
    }
}
