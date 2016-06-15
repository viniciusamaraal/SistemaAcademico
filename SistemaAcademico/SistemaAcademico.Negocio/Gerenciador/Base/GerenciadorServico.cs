using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.Base;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador.Base
{
    public class GerenciadorServico<TServico> : GerenciadorDominio<TServico> where TServico : Servico
    {
        public GerenciadorServico(RegistraErro registraErro) : base(registraErro)
        {
        }

        public override bool Inserir(TServico entidade, bool apenasValidar = false)
        {
            var erroEncontrado = false;

            if (entidade.Status != Servico.StatusServico.Pendente)
                RegistrarErro(nameof(entidade.Status), "Não é possível cadastrar serviço com esse status.", ref erroEncontrado);

            // Entity Framework 6 não tem suporte pronto para Valores Default.
            entidade.DataRequisicao = DateTime.Now;

            return base.Inserir(entidade, apenasValidar || erroEncontrado);
        }
    }
}
