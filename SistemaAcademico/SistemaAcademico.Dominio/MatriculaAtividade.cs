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
    public class MatriculaAtividade : Base.Dominio
    {
        public double Nota { get; set; }

        [ForeignKey(nameof(Atividade))]
        public int IdAtividade { get; set; }
        [ForeignKey(nameof(MatriculaOferta))]
        public int IdMatriculaOferta { get; set; }

        public virtual Atividade Atividade { get; set; }
        public virtual MatriculaOferta MatriculaOferta { get; set; }
    }
}
