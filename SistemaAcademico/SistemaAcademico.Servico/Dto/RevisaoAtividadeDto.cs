using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static SistemaAcademico.Dominio.Base.Servico;

namespace SistemaAcademico.Servico.Dto
{
    [DataContract]
    public class RevisaoAtividadeDto : Dto.Base.DtoDominio<RevisaoAtividade>
    {
        public RevisaoAtividadeDto()
        {

        }

        public RevisaoAtividadeDto(RevisaoAtividade revisao)
        {
            ConstruirDto(revisao);
        }

        [DataMember]
        public int IdAlunoAtividade { get; set; }

        [DataMember]
        public string NomeDisciplina { get; set; }

        [DataMember]
        public string NomeAtividade { get; set; }

        [DataMember]
        public DateTime DataAtividade { get; set; }

        [DataMember]
        public DateTime DataRequisicao { get; set; }

        [DataMember]
        public string Justificativa { get; set; }

        [DataMember]
        public int IdStatus { get; set; }

        [DataMember]
        public string NomeStatus { get; set; }

        public override RevisaoAtividade ConstruirDominio()
        {
            return new RevisaoAtividade
            {
                Id = this.Id,
                IdAlunoAtividade = this.IdAlunoAtividade,
                DataRequisicao = this.DataRequisicao,
                Justificativa = this.Justificativa,
                Status = (StatusServico)this.IdStatus
            };
        }

        public override void ConstruirDto(RevisaoAtividade revisao)
        {
            base.Id = revisao.Id;
            this.IdAlunoAtividade = revisao.IdAlunoAtividade;
            this.NomeDisciplina = revisao.AlunoAtividade.Atividade.Oferta.GradeDisciplina.Disciplina.Nome;
            this.NomeAtividade = revisao.AlunoAtividade.Atividade.Nome;
            this.DataAtividade = revisao.AlunoAtividade.Atividade.Data;
            this.DataRequisicao = revisao.DataRequisicao;
            this.Justificativa = revisao.Justificativa;
            this.IdStatus = (int)revisao.Status;
            this.NomeStatus = revisao.Status.ToString();
        }
    }
}
