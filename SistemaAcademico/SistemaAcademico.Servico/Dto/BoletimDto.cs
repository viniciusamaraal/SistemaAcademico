using SistemaAcademico.Dominio;
using SistemaAcademico.Servico.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Dto
{
    [DataContract]
    public class BoletimDto
    {
        public BoletimDto()
        {

        }

        public BoletimDto(int idMatricula, IEnumerable<IGrouping<Disciplina, MatriculaAtividade>> boletim)
        {
            ConstruirDto(idMatricula, boletim);
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember(Name = "Disciplinas")]
        public IEnumerable<BoletimDisciplinaDto> BoletimDisciplinas { get; set; }

        public void ConstruirDto(int idMatricula, IEnumerable<IGrouping<Disciplina, MatriculaAtividade>> boletim)
        {
            this.Id = idMatricula;

            this.BoletimDisciplinas = new List<BoletimDisciplinaDto>(boletim.Select(b => new BoletimDisciplinaDto(b.Key, b)));
        }
    }
}
