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
    public class BoletimDisciplinaDto
    {
        public BoletimDisciplinaDto()
        {

        }

        public BoletimDisciplinaDto(Disciplina disciplina, IEnumerable<MatriculaAtividade> matriculaAtividade)
        {
            ConstruirDto(disciplina, matriculaAtividade);
        }

        [DataMember]
        public Disciplina Disciplina { get; set; }

        [DataMember(Name = "Atividades")]
        public IEnumerable<BoletimAtividadeDto> MatriculaAtividades { get; set; }

        public void ConstruirDto(Disciplina disciplina, IEnumerable<MatriculaAtividade> matriculaAtividade)
        {
            this.Disciplina = disciplina;

            this.MatriculaAtividades = new List<BoletimAtividadeDto>(matriculaAtividade.Select(ma => new BoletimAtividadeDto(ma)));
        }
    }
}
