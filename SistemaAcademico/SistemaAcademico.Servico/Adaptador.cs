using SistemaAcademico.Negocio;
using SistemaAcademico.Negocio.Gerenciador;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico
{
    // TODO: Revisar nome da classe Adaptador.
    public class Adaptador: IDisposable
    {
        private readonly RegistraErro registrarErro;

        public Adaptador()
        {
        }

        public Adaptador(RegistraErro registrarErro)
        {
            this.registrarErro = registrarErro;
        }

        private GerenciadorDisciplina _gerenciadorDisciplina;
        public GerenciadorDisciplina GerenciadorDisciplina
        {
            get
            {
                if (this._gerenciadorDisciplina == null)
                    this._gerenciadorDisciplina = new GerenciadorDisciplina(registrarErro);

                return this._gerenciadorDisciplina;
            }
        }

        private GerenciadorRetificacaoFalta _gerenciadorRetificacaoFalta;
        public GerenciadorRetificacaoFalta GerenciadorRetificacaoFalta
        {
            get
            {
                if (this._gerenciadorRetificacaoFalta == null)
                    this._gerenciadorRetificacaoFalta = new GerenciadorRetificacaoFalta(registrarErro);

                return this._gerenciadorRetificacaoFalta;
            }
        }

        private GerenciadorMatricula _gerenciadorMatricula;
        public GerenciadorMatricula GerenciadorMatricula
        {
            get
            {
                if (this._gerenciadorMatricula == null)
                    this._gerenciadorMatricula = new GerenciadorMatricula(registrarErro);

                return this._gerenciadorMatricula;
            }
        }

        private GerenciadorUsuario _gerenciadorUsuario;
        public GerenciadorUsuario GerenciadorUsuario
        {
            get
            {
                if (this._gerenciadorUsuario == null)
                    this._gerenciadorUsuario = new GerenciadorUsuario(registrarErro);

                return this._gerenciadorUsuario;
            }
        }

        private GerenciadorAluno _gerenciadorAluno;
        public GerenciadorAluno GerenciadorAluno
        {
            get
            {
                if (this._gerenciadorAluno == null)
                    this._gerenciadorAluno = new GerenciadorAluno(registrarErro);

                return this._gerenciadorAluno;
            }
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
                _gerenciadorDisciplina?.Dispose();
                _gerenciadorRetificacaoFalta?.Dispose();
                _gerenciadorMatricula?.Dispose();
                _gerenciadorUsuario?.Dispose();
                _gerenciadorAluno?.Dispose();
            }
        }
    }
}
