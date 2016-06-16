using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorMatricula : Gerenciador.Base.Gerenciador
    {
        public GerenciadorMatricula(RegistraErro registraErro) : base(registraErro)
        {
        }

        // TODO: Definir em qual controller isso deve ser chamado:
        // Listas as disciplinas do aluno no momento para os serviços de retificação.
        public IEnumerable<MatriculaOferta> BuscarDisciplinas(int idMatricula)
        {
            return adaptador.RepositorioMatriculaOferta.BuscarPorMatricula(idMatricula);
        }

        public IEnumerable<Matricula> BuscarMatriculas(int idAluno)
        {
            return adaptador.RepositorioMatricula.BuscaPorAluno(idAluno);
        }
    }
}
