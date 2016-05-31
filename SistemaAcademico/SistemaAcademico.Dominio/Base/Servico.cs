using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio.Base
{
    public abstract class Servico: Dominio
    {
        public DateTime Data { get; set; }
        public StatusServico Status { get; set; }
        public string Justificativa { get; set; }

        public enum StatusServico
        {
            Pendente,
            Aprovado,
            Rejeitado
        }
    }
}
