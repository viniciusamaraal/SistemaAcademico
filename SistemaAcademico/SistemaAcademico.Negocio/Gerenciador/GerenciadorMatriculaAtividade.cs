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
    public class GerenciadorMatriculaAtividade : GerenciadorDominio<MatriculaAtividade>
    {
        public GerenciadorMatriculaAtividade(RegistraErro registraErro) : base(registraErro)
        {
        }

        public IEnumerable<IGrouping<MatriculaOferta, MatriculaAtividade>> BuscaAtividadesPorMatricula(int idMatricula)
        {
            return adaptador.RepositorioMatriculaAtividade.BuscarPorMatricula(idMatricula);
        }

        public IEnumerable<IGrouping<Matricula, IGrouping<MatriculaOferta, MatriculaAtividade>>> BuscaAtividadesPorAluno(int idAluno)
        {
            return adaptador.RepositorioMatriculaAtividade.BuscarPorAluno(idAluno);
        }
    }
}
