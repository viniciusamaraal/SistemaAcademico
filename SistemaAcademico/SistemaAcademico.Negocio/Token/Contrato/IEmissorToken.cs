using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Token.Contrato
{
    public interface IEmissorToken
    {
        string CriaToken();
        bool ValidaToken(string token);
    }
}
