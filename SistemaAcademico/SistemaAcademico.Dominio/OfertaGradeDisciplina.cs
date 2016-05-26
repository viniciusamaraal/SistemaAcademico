using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class OfertaGradeDisciplina
    {
        public int Id { get; set; }

        [ForeignKey(nameof(GradeDisciplina))]
        public int IdGradeDisciplina { get; set; }

        [ForeignKey(nameof(Professor))]
        public int IdProfessor { get; set; }

        public virtual GradeDisciplina GradeDisciplina { get; set; }
        public virtual Professor Professor { get; set; }

        public virtual ICollection<Atividade> Atividades { get; set; }
        public virtual ICollection<MatriculaOfertaGradeDisciplina> MatriculasOfertasDisciplina { get; set; }
    }
}
