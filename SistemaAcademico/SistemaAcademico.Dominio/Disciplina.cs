using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        public virtual ICollection<GradeDisciplina> GradesCurricularesDisciplina { get; set; }
    }
}
