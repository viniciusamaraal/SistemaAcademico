using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class OfertaDisciplina
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Disciplina))]
        public int IdDisciplina { get; set; }

        [ForeignKey(nameof(Professor))]
        public int IdProfessor { get; set; }

        public virtual Disciplina Disciplina { get; set; }
        public virtual Professor Professor { get; set; }

        public virtual ICollection<Atividade> Atividades { get; set; }
        public virtual ICollection<MatriculaOfertaDisciplina> MatriculasOfertasDisciplina { get; set; }
    }
}
