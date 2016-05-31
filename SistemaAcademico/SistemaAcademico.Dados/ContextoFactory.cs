using SistemaAcademico.Dados.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados
{
    public class ContextoFactory
    {
        /// <summary>
        /// Decide qual contexto deverá ser criado no momento.
        /// </summary>
        public static IContexto CriaContexto()
        {
            return ContextoEntity.CriaContexto("name=Contexto");
        }
    }
}
