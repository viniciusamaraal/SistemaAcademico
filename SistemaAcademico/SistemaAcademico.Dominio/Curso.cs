using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<GradeCurricular> GradeCurricular { get; set; }
    }
}
