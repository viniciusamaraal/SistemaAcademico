using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Grade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey(nameof(Curso))]
        public int IdCurso { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual ICollection<GradeDisciplina> GradesCurricularesDisciplina { get; set; }
    }
}
