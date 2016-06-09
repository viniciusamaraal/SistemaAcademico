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
    public class GerenciadorDisciplina : GerenciadorDominio<Disciplina>
    {
        public GerenciadorDisciplina(RegistraErro registraErro) : base(registraErro)
        {
        }

    }
}
