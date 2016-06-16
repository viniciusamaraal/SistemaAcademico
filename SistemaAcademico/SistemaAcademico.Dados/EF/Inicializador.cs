using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;

namespace SistemaAcademico.Dados.EF
{
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
                new Grade {Nome = "Grade v1", IdCurso = 1 }
            }.Adicionar(contexto);

            new List<Disciplina>
            {
                new Disciplina {Nome = "AEDS I" },
                new Disciplina {Nome = "Cálculo I" },
                new Disciplina {Nome = "AEDS II" }
            }.Adicionar(contexto);

            new List<GradeDisciplina>
            {
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 3 }
            }.Adicionar(contexto);

            new List<Usuario>
            {
                new Usuario {Login= "jose", Senha= "$2a$08$EMgN29i6OLLiqy.Zj6XKbuiluLZibX2Eqz6txGk8mFNxjeTdHmvKK" },  // Senha = 123456
                new Usuario {Login= "joao", Senha= "$2a$08$EMgN29i6OLLiqy.Zj6XKbuiluLZibX2Eqz6txGk8mFNxjeTdHmvKK" },  // Senha = 123456
                new Usuario {Login= "harry", Senha = "$2a$08$Q1KFtweicHfp1LLztxiSWO2sdX6Hv9LootUhkuEN71qwphkuElfVC" } // Senha = 123456
            }.Adicionar(contexto);

            new List<Professor>
            {
                new Professor {Nome= "José (DCC)", IdUsuario = 1 },
                new Professor {Nome= "João (MAT)", IdUsuario = 2 }
            }.Adicionar(contexto);


            new List<Aluno> // TODO: Impedir professor e aluno com mesmo usuário?
            {
                new Aluno {Nome= "Pedro", IdUsuario = 3 }
            }.Adicionar(contexto);

            new List<Oferta>
            {
                new Oferta {IdGradeDisciplina = 1, IdProfessor = 1 },
                new Oferta {IdGradeDisciplina = 2, IdProfessor = 2 },
                new Oferta {IdGradeDisciplina = 3, IdProfessor = 1 }
            }.Adicionar(contexto);

            new List<Matricula>
            {
                new Matricula {Periodo = 1, IdAluno = 1 },
                new Matricula {Periodo = 2, IdAluno = 1 }
            }.Adicionar(contexto);

            new List<MatriculaOferta>
            {
                new MatriculaOferta {IdMatricula = 1, IdOferta = 1 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 2 },
                new MatriculaOferta {IdMatricula = 2, IdOferta = 2 },
                new MatriculaOferta {IdMatricula = 2, IdOferta = 3 },
            }.Adicionar(contexto);

            new List<Atividade>
            {
                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 50, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 50, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "Prova", Valor= 100, IdOferta = 2 },
                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 40, IdOferta = 3 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 60, IdOferta = 3 }
            }.Adicionar(contexto);

            new List<MatriculaAtividade>
            {
                new MatriculaAtividade {IdAtividade = 1, IdMatriculaOferta = 1, Nota = 48 },
                new MatriculaAtividade {IdAtividade = 2, IdMatriculaOferta = 1, Nota = 50 },
                new MatriculaAtividade {IdAtividade = 3, IdMatriculaOferta = 2, Nota = 55 },
                new MatriculaAtividade {IdAtividade = 3, IdMatriculaOferta = 3, Nota = 65 },
                new MatriculaAtividade {IdAtividade = 4, IdMatriculaOferta = 4, Nota = 40 },
                new MatriculaAtividade {IdAtividade = 5, IdMatriculaOferta = 4, Nota = 56 },
            }.Adicionar(contexto);

            new List<RetificacaoFalta>
            {
                new RetificacaoFalta {IdMatricula = 1, IdOferta = 1, DataRequisicao=DateTime.Now, DataFalta = DateTime.Now.Date.AddDays(-10), Justificativa = "Estava em conferência." }
            }.Adicionar(contexto);
        }
    }
}

