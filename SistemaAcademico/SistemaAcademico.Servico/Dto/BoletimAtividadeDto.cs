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
    public class BoletimAtividadeDto : DtoDominio<MatriculaAtividade>
    {
        public BoletimAtividadeDto()
        {

        }

        public BoletimAtividadeDto(MatriculaAtividade matriculaAtividade)
        {
            ConstruirDto(matriculaAtividade);
        }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public double Valor { get; set; }

        [DataMember]
        public double Nota { get; set; }

        [DataMember]
        public DateTime Data { get; set; }

        public override MatriculaAtividade ConstruirDominio()
        {
            throw new NotImplementedException();
        }

        public override void ConstruirDto(MatriculaAtividade matriculaAtividade)
        {
            this.Id = matriculaAtividade.Id;
            this.Nome = matriculaAtividade.Atividade.Nome;
            this.Valor = matriculaAtividade.Atividade.Valor;
            this.Nota = matriculaAtividade.Nota;
            this.Data = matriculaAtividade.Atividade.Data;
        }
    }
}
