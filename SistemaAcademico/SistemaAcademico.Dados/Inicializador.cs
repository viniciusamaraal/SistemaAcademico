using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;

namespace SistemaAcademico.Dados
{
    // TODO: Avaliar se separamos essa classe.
    public static class InicializadorHelper
    {
        public static void Adicionar<T>(this IEnumerable<T> entidades, IContexto contexto) where T : Dominio.Base.Dominio
        {
            foreach (var entidade in entidades)
                contexto.Set<T>().Add(entidade);

            contexto.SalvarAlteracoes();
        }
    }

    internal class Inicializador : DropCreateDatabaseIfModelChanges<ContextoEntity>
    {
        protected override void Seed(ContextoEntity contexto)
        {
            new List<Curso>
            {
                new Curso { Nome = "Ciência da Computação" },
                new Curso { Nome = "Engenharia da Computação" },
                new Curso { Nome = "Engenharia de Software" },
                new Curso { Nome = "Sistemas de Informação" },
            }.Adicionar(contexto);

            new List<Grade>
            {
                new Grade {Nome = "Oferta 1", IdCurso = 1 }
            }.Adicionar(contexto);

            new List<Disciplina>
            {
                new Disciplina {Nome = "AEDS I" },
                new Disciplina {Nome = "Cálculo I" }
            }.Adicionar(contexto);

            new List<GradeDisciplina>
            {
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 }
            }.Adicionar(contexto);

            new List<Usuario>
            {
                new Usuario {Login= "jose" },
                new Usuario {Login= "harry" }
            }.Adicionar(contexto);

            new List<Professor>
            {
                new Professor {Nome= "José", IdUsuario = 1 }
            }.Adicionar(contexto);


            new List<Aluno> // TODO: Corrigir para impedir professor e aluno com mesmo usuário.
            {
                new Aluno {Nome= "Pedro", IdUsuario = 2 }
            }.Adicionar(contexto);

            new List<OfertaGradeDisciplina>
            {
                new OfertaGradeDisciplina {IdGradeDisciplina = 1, IdProfessor = 1 },
                new OfertaGradeDisciplina {IdGradeDisciplina = 2, IdProfessor = 1 }
            }.Adicionar(contexto);

            new List<Matricula>
            {
                new Matricula {Periodo = 1, IdAluno = 1 }
            }.Adicionar(contexto);

            new List<MatriculaOfertaGradeDisciplina>
            {
                new MatriculaOfertaGradeDisciplina {IdMatricula = 1, IdOfertaGradeDisciplina = 1 },
                new MatriculaOfertaGradeDisciplina {IdMatricula = 1, IdOfertaGradeDisciplina = 2 }
            }.Adicionar(contexto);

            new List<Atividade>
            {
                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOfertaGradeDisciplina = 1 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 15, IdOfertaGradeDisciplina = 1 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 1", Valor= 10, IdOfertaGradeDisciplina = 2 }
            }.Adicionar(contexto);

            new List<MatriculaAtividade>
            {
                new MatriculaAtividade {IdAtividade = 1, IdMatriculaOfertaGradeDisciplina = 1, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 2, IdMatriculaOfertaGradeDisciplina = 1, Nota = 12 },
                new MatriculaAtividade {IdAtividade = 3, IdMatriculaOfertaGradeDisciplina = 2, Nota = 10 },
            }.Adicionar(contexto);
        }
    }
}

