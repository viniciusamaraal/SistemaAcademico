using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Models.Dto.Base
{
    public abstract class Dto <TDominio> where TDominio: Dominio.Base.Dominio
    {
        public abstract TDominio Constroi();
    }
}
