using SistemaAcademico.Dominio.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public Pessoa Pessoa
        {
            get
            {
                return (Pessoa)Alunos?.FirstOrDefault() ?? Professores?.FirstOrDefault();
            }
        }

        public virtual ICollection<Aluno> Alunos { get; set; }

        public virtual ICollection<Professor> Professores { get; set; }
    }
}
