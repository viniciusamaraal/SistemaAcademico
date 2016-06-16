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
    public class Atividade : Base.Dominio
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        [ForeignKey(nameof(Oferta))]
        public int IdOferta { get; set; }

        public virtual Oferta Oferta { get; set; }

        public virtual ICollection<MatriculaAtividade> AlunoAtividades { get; set; }
    }
}
