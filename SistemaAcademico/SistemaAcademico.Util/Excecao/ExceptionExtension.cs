using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Util.Excecao
{
    public static class ExceptionExtension
    {
        public static IEnumerable<string> BuscaTodasMensagens(this Exception ex)
        {
            for (; ex != null; ex = ex.InnerException)
                yield return ex.Message;
        }
    }
}
