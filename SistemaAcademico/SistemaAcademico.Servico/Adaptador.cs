using SistemaAcademico.Negocio;
using SistemaAcademico.Negocio.Gerenciador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico
{
    public class Adaptador
    {
        private GerenciadorDisciplina _gerenciadorDisciplina;
        public GerenciadorDisciplina GerenciadorDisciplina
        {
            get
            {
                if (this._gerenciadorDisciplina == null)
                    this._gerenciadorDisciplina = new GerenciadorDisciplina();

                return this._gerenciadorDisciplina;
            }
        }

        private GerenciadorRetificacaoFalta _gerenciadorRetificacaoFalta;
        public GerenciadorRetificacaoFalta GerenciadorRetificacaoFalta
        {
            get
            {
                if (this._gerenciadorRetificacaoFalta == null)
                    this._gerenciadorRetificacaoFalta = new GerenciadorRetificacaoFalta();

                return this._gerenciadorRetificacaoFalta;
            }
        }

    }
}
