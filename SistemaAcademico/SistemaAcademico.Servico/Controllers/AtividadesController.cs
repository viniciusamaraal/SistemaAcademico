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
    public class AtividadesController : ControladorCrudDominio<Atividade>
    {
        /**
         *  Listar as atividades pelo idUsuario:
         *      Verificar no gerenciador se é aluno ou professor
         *          Se for professor listar todas as atividades de seus alunos (OfertaGradeDisciplina)
         *          Se for aluno listar todas as atividades de sua turma (AlunoAtividade)
         *
         **/
    }
}
