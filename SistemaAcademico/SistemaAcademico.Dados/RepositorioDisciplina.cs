using SistemaAcademico.Dados.Base;
using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados
{
    public class RepositorioDisciplina : Repositorio<Disciplina>
    {
        public RepositorioDisciplina() : base()
        {

        }

        public RepositorioDisciplina(IContexto contexto) : base(contexto)
        {

        }
    }
}
