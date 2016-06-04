using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Dados;

namespace SistemaAcademico.Dados
{
    // TODO: Avaliar se separamos essa classe.
    public static class InicializadorHelper
    {
        public static void Adicionar<T>(this IEnumerable<T> entidades, ContextoEntity contexto) where T : Dominio.Base.Dominio
        {
            foreach (var entidade in entidades)
                contexto.Set<T>().Add(entidade);

            contexto.SaveChanges();
        }
    }

    public class Inicializador : DropCreateDatabaseIfModelChanges<ContextoEntity>
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
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 }
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
                new OfertaGradeDisciplina {IdGradeDisciplina = 1, IdProfessor = 1 }
            }.Adicionar(contexto);

            new List<Matricula>
            {
                new Matricula {Periodo = 1, IdAluno = 1 }
            }.Adicionar(contexto);

            new List<MatriculaOfertaGradeDisciplina>
            {
                new MatriculaOfertaGradeDisciplina {IdMatricula = 1, IdOfertaGradeDisciplina = 1 }
            }.Adicionar(contexto);
        }
    }
}

