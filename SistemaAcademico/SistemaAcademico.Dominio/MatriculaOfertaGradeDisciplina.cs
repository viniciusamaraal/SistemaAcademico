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
    public class MatriculaOfertaGradeDisciplina : Base.Dominio
    {
        [ForeignKey(nameof(Matricula))]
        public int IdMatricula { get; set; }

        [ForeignKey(nameof(OfertaGradeDisciplina))]
        public int IdOfertaGradeDisciplina { get; set; }

        public virtual Matricula Matricula { get; set; }
        public virtual OfertaGradeDisciplina OfertaGradeDisciplina { get; set; }
    }
}
