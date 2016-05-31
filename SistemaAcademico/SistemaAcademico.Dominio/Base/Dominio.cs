using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio.Base
{
    [DataContract]
    public abstract class Dominio
    {
        [DataMember]
        public int Id { get; set; }
    }
}
