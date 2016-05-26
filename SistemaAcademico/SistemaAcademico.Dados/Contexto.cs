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
            Database.SetInitializer(new Inicializador());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));

            modelBuilder.Entity<Aluno>()
                .HasRequired(c => c.Usuario)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Professor>()
                .HasRequired(c => c.Usuario)
                .WithMany()
                .WillCascadeOnDelete(false);
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<AlunoAtividade> AlunoAtividade { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<GradeDisciplina> GradeDisciplina { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<MatriculaOfertaGradeDisciplina> MatriculaOfertaGradeDisciplina { get; set; }
        public DbSet<OfertaGradeDisciplina> OfertaGradeDisciplina { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<RetificacaoFalta> RetificacaoFalta { get; set; }
        public DbSet<RevisaoAtividade> RevisaoAtividade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
