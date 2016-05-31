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
    public class AlunoAtividade : Base.Dominio
    {
        public double Nota { get; set; }

        [ForeignKey(nameof(Aluno))]
        public int IdAluno { get; set; }
        [ForeignKey(nameof(Atividade))]
        public int IdAtividade { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual Atividade Atividade { get; set; }
    }
}
