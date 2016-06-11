using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.Base;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorRetificacaoFalta : GerenciadorDominio<RetificacaoFalta>
    {
        public GerenciadorRetificacaoFalta(RegistraErro registraErro) : base(registraErro)
        {
        }

        public override bool Inserir(RetificacaoFalta entidade)
        {
            var erroEncontrado = false;

            if (entidade.Status != Servico.StatusServico.Pendente)
                RegistrarErro(nameof(entidade.Status), "Não é possível cadastrar serviço com esse status.", ref erroEncontrado);
            if (entidade.Data > DateTime.Now)
                RegistrarErro(nameof(entidade.Data), "Data inválida.", ref erroEncontrado);

            if (!erroEncontrado)
                base.Inserir(entidade);

            return !erroEncontrado;
        }
    }
}
