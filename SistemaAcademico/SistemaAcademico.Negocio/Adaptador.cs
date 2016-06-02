using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio
{
    public class Adaptador
    {
        private readonly IContexto contexto;

        public Adaptador()
        {
            contexto = ContextoFactory.CriaContexto();
        }

        public Adaptador(IContexto contextoExistente)
        {
            contexto = contextoExistente;
        }

        private RepositorioDisciplina _repositorioDisciplina;
        public RepositorioDisciplina RepositorioDisciplina
        {
            get
            {
                if (this._repositorioDisciplina == null)
                    this._repositorioDisciplina = new RepositorioDisciplina(contexto);

                return this._repositorioDisciplina;
            }
        }

        private RepositorioRetificacaoFalta _repositorioRetificacaoFalta;
        public RepositorioRetificacaoFalta RepositorioRetificacaoFalta
        {
            get
            {
                if (this._repositorioRetificacaoFalta == null)
                    this._repositorioRetificacaoFalta = new RepositorioRetificacaoFalta(contexto);

                return this._repositorioRetificacaoFalta;
            }
        }

        internal void SalvarAlteracoes()
        {
            contexto.SalvarAlteracoes();
        }

        internal async void SalvarAlteracoesAsync()
        {
            await contexto.SalvarAlteracoesAsync();
        }
    }
}
