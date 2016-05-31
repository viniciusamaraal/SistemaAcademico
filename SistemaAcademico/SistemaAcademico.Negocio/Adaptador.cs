using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio
{
    public class Adaptador
    {
        private IContexto contexto;

        public Adaptador()
        {
            contexto = ContextoFactory.CriaContexto();
        }

        public Adaptador(IContexto contextoExistente)
        {
            contexto = contextoExistente;
        }

        private RepositorioDisciplina repositorioDisciplina;
        public RepositorioDisciplina RepositorioDisciplina
        {
            get
            {
                if (this.repositorioDisciplina == null)
                    this.repositorioDisciplina = new RepositorioDisciplina(contexto);

                return this.repositorioDisciplina;
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
