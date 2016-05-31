using SistemaAcademico.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico
{
    public class Adaptador
    {
        private GerenciadorDisciplina gerenciadorDisciplina;
        public GerenciadorDisciplina GerenciadorDisciplina
        {
            get
            {
                if (this.gerenciadorDisciplina == null)
                    this.gerenciadorDisciplina = new GerenciadorDisciplina();

                return this.gerenciadorDisciplina;
            }
        }

    }
}
