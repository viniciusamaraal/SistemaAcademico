﻿using SistemaAcademico.Dominio;
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

        public BoletimDto(Matricula matricula, IEnumerable<IGrouping<MatriculaOferta, MatriculaAtividade>> boletim)
        {
            ConstruirDto(matricula, boletim);
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Periodo { get; set; }

        [DataMember(Name = "Disciplinas")]
        public IEnumerable<BoletimDisciplinaDto> BoletimDisciplinas { get; set; }

        public void ConstruirDto(Matricula matricula, IEnumerable<IGrouping<MatriculaOferta, MatriculaAtividade>> boletim)
        {
            this.Id = matricula.Id;
            this.Periodo = matricula.Periodo;

            this.BoletimDisciplinas = new List<BoletimDisciplinaDto>(boletim.Select(b => new BoletimDisciplinaDto(b.Key.Oferta.GradeDisciplina.Disciplina, b)));
        }
    }
}
