using SistemaAcademico.Negocio.Token.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Token
{
    internal class EmissorTokenGuid : IEmissorToken
    {
        public string CriaToken()
        {
            return Guid.NewGuid().ToString();
        }

        public bool ValidaToken(string token)
        {
            Guid guid;
            return Guid.TryParse(token, out guid);
        }
    }
}
