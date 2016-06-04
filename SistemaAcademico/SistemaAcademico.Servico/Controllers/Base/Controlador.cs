using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Excecao.Dado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SistemaAcademico.Servico.Controllers.Base
{
    public class Controlador<T> : ApiController where T : Dominio.Base.Dominio
    {
        protected readonly Adaptador adaptador;

        public Controlador()
        {
            this.adaptador = new Adaptador(RegistraErros);
        }

        public Controlador(Adaptador adaptador)
        {
            this.adaptador = adaptador;
        }

        private Gerenciador<T> _gerenciador;
        protected Gerenciador<T> Gerenciador
        {
            get
            {
                if (_gerenciador == null)
                {
                    var propriedades = typeof(Adaptador).GetProperties();
                    foreach (PropertyInfo i in propriedades)
                    {
                        var tipo = i.PropertyType;
                        // TODO: Verificar forma melhor de buscar o tipo da propriedade:
                        if (tipo.BaseType.GenericTypeArguments.Any() &&
                            tipo.BaseType.GenericTypeArguments[0].FullName == typeof(T).FullName)
                        {
                            _gerenciador = i.GetValue(adaptador) as Gerenciador<T>;
                            break;
                        }
                    }
                    if (_gerenciador == null)
                        throw new NotImplementedException("Gerenciador não encontrado para o tipo " + typeof(T).FullName);
                }

                return _gerenciador;
            }
        }

        protected void RegistraErros(string chave, string erro)
        {
            ModelState.AddModelError(chave, erro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                Gerenciador.Dispose();

            base.Dispose(disposing);
        }
    }
}
