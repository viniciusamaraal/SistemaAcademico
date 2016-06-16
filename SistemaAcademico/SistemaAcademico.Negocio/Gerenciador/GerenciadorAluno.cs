using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorAluno : GerenciadorDominio<Aluno>
    {
        public GerenciadorAluno(RegistraErro registraErro) : base(registraErro)
        {
        }
    }
}
