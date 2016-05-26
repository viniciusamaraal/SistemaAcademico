using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        [ForeignKey(nameof(OfertaDisciplina))]
        public int IdOfertaDisciplina { get; set; }

        public virtual OfertaDisciplina OfertaDisciplina { get; set; }

        public virtual ICollection<AlunoAtividade> AlunoAtividades { get; set; }
    }
}
