using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Util.Excecao.Dado
{
    [Serializable]
    public class SalvarException : Exception
    {
        public SalvarException() { }
        public SalvarException(string message) : base(message) { }
        public SalvarException(string message, Exception inner) : base(message, inner) { }
        protected SalvarException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
