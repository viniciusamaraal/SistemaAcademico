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
    public class GerenciadorRetificacaoFalta : GerenciadorServico<RetificacaoFalta>
    {
        public GerenciadorRetificacaoFalta(RegistraErro registraErro) : base(registraErro)
        {
        }

        public override bool Inserir(RetificacaoFalta entidade, bool apenasValidar = false)
        {
            var erroEncontrado = false;

            if (entidade.DataFalta > DateTime.Now)
                RegistrarErro(nameof(entidade.DataFalta), "Data inválida.", ref erroEncontrado);

            return base.Inserir(entidade, apenasValidar || erroEncontrado);
        }
    }
}
