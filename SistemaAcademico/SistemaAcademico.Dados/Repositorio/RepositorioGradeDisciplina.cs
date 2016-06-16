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
    public class RepositorioGradeDisciplina : Repositorio<GradeDisciplina>
    {
        public RepositorioGradeDisciplina() : base()
        {
        }

        public RepositorioGradeDisciplina(IContexto contexto) : base(contexto)
        {
        }

        public override IEnumerable<GradeDisciplina> Buscar()
        {
            return dbSet.Include(g => g.Grade)
                        .Include(g=>g.Disciplina);
        }
    }
}
