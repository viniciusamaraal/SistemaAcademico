using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<AlunoAtividade> AlunoAtividades { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}  
