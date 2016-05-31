using SistemaAcademico.Dominio.Base;
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
    public class RevisaoAtividade : Servico
    {
        [ForeignKey(nameof(AlunoAtividade))]
        public int IdAlunoAtividade { get; set; }

        public virtual AlunoAtividade AlunoAtividade { get; set; }
    }
}
