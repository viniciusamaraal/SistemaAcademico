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
    // TODO: Revisar nome da classe Adaptador.
    public class Adaptador : IDisposable
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

        private RepositorioMatriculaAtividade _repositorioMatriculaAtividade;
        public RepositorioMatriculaAtividade RepositorioMatriculaAtividade
        {
            get
            {
                if (this._repositorioMatriculaAtividade == null)
                    this._repositorioMatriculaAtividade = new RepositorioMatriculaAtividade(contexto);

                return this._repositorioMatriculaAtividade;
            }
        }

        private RepositorioMatriculaOfertaGradeDisciplina _repositorioMatriculaOfertaGradeDisciplina;
        public RepositorioMatriculaOfertaGradeDisciplina RepositorioMatriculaOfertaGradeDisciplina
        {
            get
            {
                if (this._repositorioMatriculaOfertaGradeDisciplina == null)
                    this._repositorioMatriculaOfertaGradeDisciplina = new RepositorioMatriculaOfertaGradeDisciplina(contexto);

                return this._repositorioMatriculaOfertaGradeDisciplina;
            }
        }

        private RepositorioMatricula _repositorioMatricula;
        public RepositorioMatricula RepositorioMatricula
        {
            get
            {
                if (this._repositorioMatricula == null)
                    this._repositorioMatricula = new RepositorioMatricula(contexto);

                return this._repositorioMatricula;
            }
        }


        private RepositorioUsuario _repositorioUsuario;
        public RepositorioUsuario RepositorioUsuario
        {
            get
            {
                if (this._repositorioUsuario == null)
                    this._repositorioUsuario = new RepositorioUsuario(contexto);

                return this._repositorioUsuario;
            }
        }

        private RepositorioAluno _repositorioAluno;
        public RepositorioAluno RepositorioAluno
        {
            get
            {
                if (this._repositorioAluno == null)
                    this._repositorioAluno = new RepositorioAluno(contexto);

                return this._repositorioAluno;
            }
        }

        internal void SalvarAlteracoes()
        {
            contexto.SalvarAlteracoes();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repositorioDisciplina?.Dispose();
                _repositorioRetificacaoFalta?.Dispose();
                _repositorioMatriculaAtividade?.Dispose();
                _repositorioMatriculaOfertaGradeDisciplina?.Dispose();
                _repositorioMatricula?.Dispose();
                _repositorioUsuario?.Dispose();
                _repositorioAluno?.Dispose();
            }
        }
    }
}
