using SistemaAcademico.Dominio.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class RetificacaoFalta : Servico
    {
        [ForeignKey(nameof(Matricula))]
        public int IdMatricula { get; set; }

        [ForeignKey(nameof(OfertaDisciplina))]
        public int IdOfertaDisciplina { get; set; }

        public virtual Matricula Matricula { get; set; }
        public virtual OfertaDisciplina OfertaDisciplina { get; set; }
    }
}
