using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Negocio.Token;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorUsuario : GerenciadorDominio<Usuario>
    {
        public GerenciadorUsuario(RegistraErro registraErro) : base(registraErro)
        {
        }

        public bool AutenticaUsuario(string login, string senha, out Usuario usuario)
        {
            var usuarioBD = adaptador.RepositorioUsuario.BuscarPorLogin(login);
            if (usuarioBD?.Senha !=  null && BCrypt.Net.BCrypt.Verify(senha, usuarioBD.Senha))
            {
                GaranteToken(usuarioBD);
                usuario = usuarioBD;
                return true;
            }
            usuario = null;
            return false;
        }

        private void GaranteToken(Usuario usuarioBD)
        {
            if (usuarioBD.Token == null)
            {
                usuarioBD.Token = EmissorTokenFactory.BuscaEmissorToken().CriaToken();
                adaptador.RepositorioUsuario.Editar(usuarioBD);
                adaptador.SalvarAlteracoes();
            }
        }
    }
}
