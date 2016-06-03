using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio.DTO
{
    [DataContract]
    public class RetificacaoFaltaDTO : Dominio.Base.Dominio
    {
        [DataMember]
        public string NomeAluno { get; set; }

        [DataMember]
        public int IdDisciplina { get; set; }

        [DataMember]
        public string NomeDisciplina { get; set; }

        [DataMember]
        public DateTime DataFalta { get; set; }

        [DataMember]
        public string Justificativa { get; set; }

        [DataMember]
        public int IdStatus { get; set; }

        [DataMember]
        public string NomeStatus { get; set; }

        [DataMember]
        public DateTime DataRequisicao { get; set; }
    }
}
