using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Util.Excecao.Modelo
{
    [Serializable]
    public class ModeloInvalidoException : Exception
    {
        public ModeloInvalidoException() { }
        public ModeloInvalidoException(string message) : base(message) { }
        public ModeloInvalidoException(string message, Exception inner) : base(message, inner) { }
        protected ModeloInvalidoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
