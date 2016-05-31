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
            new RepositorioDisciplina().Buscar().ToList();
        }
    }
}
