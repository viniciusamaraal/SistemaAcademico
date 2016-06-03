using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio.Base
{
    [DataContract]
    public abstract class Servico : Dominio
    {
        [DataMember]
        public DateTime Data { get; set; }
        [DataMember]
        public StatusServico Status { get; set; }
        [DataMember]
        public string Justificativa { get; set; }

        public enum StatusServico
        {
            Pendente,
            Aprovado,
            Rejeitado
        }
    }
}
