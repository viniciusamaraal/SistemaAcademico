using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class AlunoAtividade
    {
        public int Id { get; set; }
        public double Nota { get; set; }

        [ForeignKey(nameof(Aluno))]
        public int IdAluno { get; set; }
        [ForeignKey(nameof(Atividade))]
        public int IdAtividade { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual Atividade Atividade { get; set; }
    }
}
