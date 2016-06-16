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
    public class Matricula : Base.Dominio
    {
        [DataMember]
        public int Periodo { get; set; }

        [ForeignKey(nameof(Aluno))]
        public int IdAluno { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual ICollection<MatriculaOferta> MatriculasOfertasGradesDisciplina { get; set; }
    }
}
