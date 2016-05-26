using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<AlunoAtividade> AlunoAtividade { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<GradeCurricular> GradeCurricular { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<OfertaDisciplina> OfertaDisciplina { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<RetificacaoFalta> RetificacaoFalta { get; set; }
        public DbSet<RevisaoAtividade> RevisaoAtividade { get; set; }
    }
}
