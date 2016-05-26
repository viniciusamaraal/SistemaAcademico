using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class GradeDisciplina
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Grade))]
        public int IdGrade { get; set; }

        [ForeignKey(nameof(Disciplina))]
        public int IdDisciplina { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        public virtual ICollection<OfertaGradeDisciplina> Ofertas { get; set; }
    }
}
