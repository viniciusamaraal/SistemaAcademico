using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SistemaAcademico.Dominio;
using SistemaAcademico.Servico.Controllers.Base;
using SistemaAcademico.Servico.Dto;

namespace SistemaAcademico.Servico.Controllers
{
    public class UsuariosController : Controlador
    {
        [HttpPost]
        [Route("api/Usuarios/Autenticar")]
        public IHttpActionResult Autenticar(AutenticacaoDto auth)
        {
            Usuario usuario;
            if (adaptador.GerenciadorUsuario.AutenticaUsuario(auth.Usuario, auth.Senha, out usuario))
                return Ok(new UsuarioDto(usuario));

            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
            {
                ReasonPhrase = "Usuário ou Senha inválidos.",
                Content = new StringContent("Usuário ou Senha inválidos.")
            });
        }
    }
}