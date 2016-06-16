using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SistemaAcademico.Dominio;
using SistemaAcademico.Servico.Controllers.Base;
using SistemaAcademico.Servico.Dto;

namespace SistemaAcademico.Servico.Controllers
{
    public class AlunosController : Controlador
    {
        [HttpGet]
        [Route("api/Alunos/{idAluno}/Matriculas")]
        public IHttpActionResult BuscaMatriculasAluno(int idAluno)
        {
            var matriculas = adaptador.GerenciadorMatricula.BuscarMatriculas(idAluno).ToList();
            if (!matriculas.Any() && !adaptador.GerenciadorAluno.Existe(idAluno))
                return NotFound();
            return Ok(matriculas);
        }
    }
}