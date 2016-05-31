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
    public class Disciplina : Base.Dominio
    {
        [DataMember]
        public string Nome { get; set; }
        
        [IgnoreDataMember]
        public virtual ICollection<GradeDisciplina> GradesCurricularesDisciplina { get; set; }
    }
}
