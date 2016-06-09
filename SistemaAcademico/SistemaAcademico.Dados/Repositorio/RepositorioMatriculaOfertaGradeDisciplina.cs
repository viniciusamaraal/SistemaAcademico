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
    public class RepositorioMatriculaOfertaGradeDisciplina : Repositorio<MatriculaOfertaGradeDisciplina>
    {
        public RepositorioMatriculaOfertaGradeDisciplina() : base()
        {

        }

        public RepositorioMatriculaOfertaGradeDisciplina(IContexto contexto) : base(contexto)
        {

        }

        public IEnumerable<MatriculaOfertaGradeDisciplina> BuscarPorMatricula(int idMatricula)
        {
            return dbSet.Include(m => m.OfertaGradeDisciplina.GradeDisciplina.Disciplina)
                        .Where(m => m.IdMatricula == idMatricula);
        }
    }
}
