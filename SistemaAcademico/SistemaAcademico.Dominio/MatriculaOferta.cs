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
    public class MatriculaOferta : Base.Dominio
    {
        [ForeignKey(nameof(Matricula))]
        public int IdMatricula { get; set; }

        [ForeignKey(nameof(Oferta))]
        public int IdOferta { get; set; }

        public virtual Matricula Matricula { get; set; }
        public virtual Oferta Oferta { get; set; }
        public virtual ICollection<MatriculaAtividade> MatriculaAtividades { get; set; }
    }
}
