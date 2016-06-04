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
    public class GerenciadorRetificacaoFalta : Gerenciador<RetificacaoFalta>
    {
        public GerenciadorRetificacaoFalta(RegistraErro registraErro) : base(registraErro)
        {
        }

        public override void Inserir(RetificacaoFalta entidade)
        {
            // TODO: (!!!) Definir como o usuário receberá esse erro e como bloquear a inserção.
            if (entidade.Status != Servico.StatusServico.Pendente)
                registrarErro?.Invoke(nameof(entidade.Status), "Não é possível cadastrar serviço com esse status.");
            if (entidade.Data > DateTime.Now)
                registrarErro?.Invoke(nameof(entidade.Data), "Data inválida.");

            base.Inserir(entidade);
        }
    }
}
