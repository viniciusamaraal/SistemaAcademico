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
    public class RepositorioMatriculaOferta : Repositorio<MatriculaOferta>
    {
        public RepositorioMatriculaOferta() : base()
        {

        }

        public RepositorioMatriculaOferta(IContexto contexto) : base(contexto)
        {

        }

        public IEnumerable<MatriculaOferta> BuscarPorMatricula(int idMatricula)
        {
            return dbSet.Include(m => m.Oferta.GradeDisciplina.Disciplina)
                        .Where(m => m.IdMatricula == idMatricula);
        }
    }
}
