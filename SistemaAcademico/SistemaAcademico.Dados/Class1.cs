using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados
{
    public class Class1
    {
        public static void FazAlgo()
        {
            new Contexto().GradeCurricular.ToList();
        }
    }
}
