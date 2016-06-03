using SistemaAcademico.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados
{
    public class ClasseTeste
    {
        public static void FazAlgo()
        {
            using (var repositorioDisciplina = new RepositorioDisciplina())
            {
                repositorioDisciplina.Buscar().ToList();
            }
        }
    }
}
