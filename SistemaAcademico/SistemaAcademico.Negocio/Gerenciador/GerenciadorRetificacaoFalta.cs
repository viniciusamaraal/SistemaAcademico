using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.DTO;
using SistemaAcademico.Negocio.Gerenciador.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorRetificacaoFalta : Gerenciador<RetificacaoFalta>
    {
        public new IEnumerable<RetificacaoFaltaDTO> Buscar()
        {
            return Repositorio.Buscar().Select(rf => new RetificacaoFaltaDTO(rf));
        }
    }
}
