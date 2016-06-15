using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.Base;
using SistemaAcademico.Servico.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Dto
{
    public class UsuarioDto : DtoDominio<Usuario>
    {
        public UsuarioDto()
        {
        }

        public UsuarioDto(Usuario usuario)
        {
            ConstruirDto(usuario);
        }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Token { get; set; }

        [DataMember]
        public int IdPerfil { get; set; }

        [DataMember]
        public string NomePerfil { get; set; }

        public override Usuario ConstruirDominio()
        {
            throw new NotImplementedException();
        }

        public override void ConstruirDto(Usuario usuario)
        {
            this.Id = usuario.Id;
            this.Login = usuario.Login;
            this.Token = usuario.Token;
            var pessoa = usuario.Pessoa;
            this.Nome = pessoa?.Nome;
            this.IdPerfil = (int)(pessoa?.Perfil ?? 0);
            this.NomePerfil = ((PerfilPessoa)this.IdPerfil).ToString();
        }
    }
}
