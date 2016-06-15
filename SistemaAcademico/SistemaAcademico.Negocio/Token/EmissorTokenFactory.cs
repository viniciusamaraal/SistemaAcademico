using SistemaAcademico.Negocio.Token.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Token
{
    public class EmissorTokenFactory
    {
        private static readonly IEmissorToken _emissor = new EmissorTokenGuid();
        public static IEmissorToken BuscaEmissorToken()
        {
            // TODO: Fazer token issuers mais interessantes.
            return _emissor;
        }
    }
}
