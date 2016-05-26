using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Matricula
    {
        public int Id { get; set; }
        public int Periodo { get; set; }

        [ForeignKey(nameof(Aluno))]
        public int IdAluno { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual ICollection<MatriculaOfertaDisciplina> MatriculasOfertasDisciplina { get; set; }
    }
}
