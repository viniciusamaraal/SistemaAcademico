using SistemaAcademico.Dominio.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    [DataContract]
    public class RetificacaoFalta : Servico
    {
        [ForeignKey(nameof(Matricula))]
        public int IdMatricula { get; set; }

        [ForeignKey(nameof(Oferta))]
        public int IdOferta { get; set; }

        [DataMember]
        public DateTime DataFalta { get; set; }

        public virtual Matricula Matricula { get; set; }
        public virtual Oferta Oferta { get; set; }
    }
}
