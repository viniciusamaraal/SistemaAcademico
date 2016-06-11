using SistemaAcademico.Dados.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados
{
    public static class InicializadorHelper
    {
        public static void Adicionar<T>(this IEnumerable<T> entidades, IContexto contexto) where T : Dominio.Base.Dominio
        {
            foreach (var entidade in entidades)
                contexto.Set<T>().Add(entidade);

            contexto.SalvarAlteracoes();
        }
    }
}
