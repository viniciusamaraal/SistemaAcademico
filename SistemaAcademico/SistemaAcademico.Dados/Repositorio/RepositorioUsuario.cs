using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio.Base;
using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.Repositorio
{
    public class RepositorioUsuario : Repositorio<Usuario>
    {
        public RepositorioUsuario() : base()
        {

        }

        public RepositorioUsuario(IContexto contexto) : base(contexto)
        {

        }

        public Usuario BuscarPorLogin(string login)
        {
            return dbSet.Include(u => u.Professores)
                        .Include(u => u.Alunos)
                        .Where(u => u.Login == login)
                        .FirstOrDefault();
        }
    }
}
