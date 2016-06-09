using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio.Base;
using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.Repositorio
{
    public class RepositorioMatriculaAtividade : Repositorio<MatriculaAtividade>
    {
        public RepositorioMatriculaAtividade() : base()
        {

        }

        public RepositorioMatriculaAtividade(IContexto contexto) : base(contexto)
        {

        }

        public IEnumerable<MatriculaAtividade> BuscarPorMatricula(int idMatricula)
        {
            return dbSet.Include(m => m.MatriculaOfertaGradeDisciplina.OfertaGradeDisciplina.GradeDisciplina.Disciplina)
                        .Include(m => m.Atividade)
                        .Where(m => m.MatriculaOfertaGradeDisciplina.IdMatricula == idMatricula);
        }
    }
}
