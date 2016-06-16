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
    public class RepositorioMatricula : Repositorio<Matricula>
    {
        public RepositorioMatricula() : base()
        {

        }

        public RepositorioMatricula(IContexto contexto) : base(contexto)
        {

        }

        public IEnumerable<Matricula> BuscaPorAluno(int idAluno)
        {
            return dbSet.Where(m => m.IdAluno == idAluno);
        }
    }
}
