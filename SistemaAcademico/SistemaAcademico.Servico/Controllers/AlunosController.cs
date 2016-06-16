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
            if (matriculas.Count < 1 && !adaptador.GerenciadorAluno.Existe(idAluno))
                return NotFound();

            return Ok(matriculas);
        }

        [HttpGet]
        [Route("api/Alunos/{idAluno}/Historico")]
        public IHttpActionResult BuscaHistoricoAluno(int idAluno)
        {
            var atividades = adaptador.GerenciadorMatriculaAtividade.BuscaAtividadesPorAluno(idAluno).ToList();
            if (atividades.Count < 1 && !adaptador.GerenciadorAluno.Existe(idAluno))
                return NotFound();

            return Ok(atividades.Select(a => new BoletimDto(a.Key, a)));
        }
    }
}