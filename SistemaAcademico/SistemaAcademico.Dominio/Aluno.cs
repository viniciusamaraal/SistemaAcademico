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
    public class Aluno : Pessoa
    {
        [ForeignKey(nameof(Usuario))]
        public int IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }

        public override PerfilPessoa Perfil
        {
            get { return PerfilPessoa.Aluno; }
        }
    }
}
