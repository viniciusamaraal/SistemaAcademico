using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    [DataContract]
    public class Usuario : Base.Dominio
    {
        public string Login { get; set; }

        public string Senha { get; set; }

        /// <summary>
        /// Token de autenticação.
        /// </summary>
        public string Token { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }

        public virtual ICollection<Professor> Professores { get; set; }
    }
}
