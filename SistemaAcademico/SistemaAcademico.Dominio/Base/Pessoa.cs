using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio.Base
{
    [DataContract]
    public abstract class Pessoa : Dominio
    {
        [DataMember]
        public string Nome { get; set; }

        public abstract PerfilPessoa Perfil { get; }
    }
}
