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
    public class GradeDisciplina : Base.Dominio
    {
        [ForeignKey(nameof(Grade))]
        public int IdGrade { get; set; }

        [ForeignKey(nameof(Disciplina))]
        public int IdDisciplina { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        public virtual ICollection<Oferta> Ofertas { get; set; }
    }
}
