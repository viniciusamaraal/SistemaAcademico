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

        public override IEnumerable<MatriculaAtividade> Buscar()
        {
            return dbSet.Include(m => m.MatriculaOferta.Oferta.GradeDisciplina.Disciplina)
                        .Include(m => m.Atividade)
                        .Include(m => m.MatriculaOferta.Matricula);
        }

        public IEnumerable<IGrouping<MatriculaOferta, MatriculaAtividade>> BuscarPorMatricula(int idMatricula)
        {
            return Buscar().Where(m => m.MatriculaOferta.IdMatricula == idMatricula)
                           .GroupBy(ma => ma.MatriculaOferta);
        }

        public IEnumerable<IGrouping<Matricula, IGrouping<MatriculaOferta, MatriculaAtividade>>> BuscarPorAluno(int idAluno)
        {
            return Buscar().Where(ma => ma.MatriculaOferta.Matricula.IdAluno == idAluno)
                           .GroupBy(ma => ma.MatriculaOferta)
                           .GroupBy(g => g.Key.Matricula)
                           .OrderBy(g => g.Key.Periodo);
        }
    }
}
