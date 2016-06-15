using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime DataRequisicao { get; set; }

        [DataMember]
        public StatusServico Status { get; set; }

        [DataMember]
        [Required]
        public string Justificativa { get; set; }

        public enum StatusServico
        {
            Pendente,
            Aprovado,
            Rejeitado
        }
    }
}
