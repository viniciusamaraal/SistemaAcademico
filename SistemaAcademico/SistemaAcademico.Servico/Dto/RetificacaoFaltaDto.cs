using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static SistemaAcademico.Dominio.Base.Servico;

namespace SistemaAcademico.Servico.Dto
{
    [DataContract]
    public class RetificacaoFaltaDTO : Dto.Base.DtoDominio<RetificacaoFalta>
    {
        public RetificacaoFaltaDTO()
        {

        }

        public RetificacaoFaltaDTO(RetificacaoFalta retificacao)
        {
            ConstruirDto(retificacao);
        }

        [DataMember]
        [Required]
        public int IdMatricula { get; set; }

        [DataMember]
        [Required]
        public int IdOfertaGradeDisciplina { get; set; }

        [DataMember]
        public string NomeAluno { get; set; }

        [DataMember]
        public Disciplina Disciplina { get; set; }

        [DataMember]
        [Required]
        public DateTime DataFalta { get; set; }

        [DataMember]
        [Required]
        public string Justificativa { get; set; }

        [DataMember]
        public int IdStatus { get; set; }

        [DataMember]
        public string NomeStatus { get; set; }

        [DataMember]
        public DateTime DataRequisicao { get; set; }

        public override RetificacaoFalta ConstruirDominio()
        {
            return new RetificacaoFalta
            {
                Id = this.Id,
                Data = this.DataFalta,
                IdMatricula = this.IdMatricula,
                IdOfertaGradeDisciplina = this.IdOfertaGradeDisciplina,
                Justificativa = this.Justificativa,
                Status = (StatusServico)this.IdStatus
            };
        }

        public override void ConstruirDto(RetificacaoFalta retificacao)
        {
            base.Id = retificacao.Id;
            this.IdMatricula = retificacao.IdMatricula;
            this.IdOfertaGradeDisciplina = retificacao.IdOfertaGradeDisciplina;
            this.NomeAluno = retificacao.Matricula.Aluno.Nome;
            this.Disciplina = retificacao.OfertaGradeDisciplina.GradeDisciplina.Disciplina;
            this.DataFalta = retificacao.Data;
            this.Justificativa = retificacao.Justificativa;
            this.IdStatus = (int)retificacao.Status;
            this.NomeStatus = retificacao.Status.ToString();
            this.DataRequisicao = retificacao.Data; // TODO: Mapear no banco.
        }
    }
}
