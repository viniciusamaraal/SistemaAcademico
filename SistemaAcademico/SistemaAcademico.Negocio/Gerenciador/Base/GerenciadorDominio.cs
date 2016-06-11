using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador.Base
{
    public class GerenciadorDominio<T> : Gerenciador where T : Dominio.Base.Dominio
    {
        public GerenciadorDominio()
            : this(null)
        {
        }

        public GerenciadorDominio(RegistraErro registroErros)
            : this(registroErros, new Adaptador())
        {
        }

        public GerenciadorDominio(RegistraErro registroErros, Adaptador adaptador)
            : base(registroErros, adaptador)
        {
        }

        public GerenciadorDominio(RegistraErro registroErros, IContexto contextoExistente)
            : this(registroErros, new Adaptador(contextoExistente))
        {
        }

        private Repositorio<T> _repositorio;
        protected Repositorio<T> Repositorio
        {
            get
            {
                if (_repositorio == null)
                {
                    var propriedades = typeof(Adaptador).GetProperties();
                    foreach (PropertyInfo i in propriedades)
                    {
                        var tipo = i.PropertyType;
                        // TODO: Verificar forma melhor de buscar o tipo da propriedade:
                        if (tipo.BaseType.GenericTypeArguments.Any() &&
                            tipo.BaseType.GenericTypeArguments[0].FullName == typeof(T).FullName)
                        {
                            _repositorio = i.GetValue(adaptador) as Repositorio<T>;
                            break;
                        }
                    }
                    if (_repositorio == null)
                        throw new NotImplementedException("Repositório não encontrado para o tipo " + typeof(T).FullName);
                }

                return _repositorio;
            }
        }

        public virtual IEnumerable<T> Buscar()
        {
            return Repositorio.Buscar();
        }

        public virtual T Buscar(int id)
        {
            return Repositorio.Buscar(id);
        }

        public virtual bool Editar(T entidade)
        {
            Repositorio.Editar(entidade);
            adaptador.SalvarAlteracoes();
            return true;
        }

        public virtual bool Inserir(T entidade)
        {
            Repositorio.Inserir(entidade);
            adaptador.SalvarAlteracoes();
            return true;
        }

        public virtual void Excluir(int id)
        {
            Repositorio.Excluir(id);
            adaptador.SalvarAlteracoes();
        }

        public virtual bool Existe(int id)
        {
            return Repositorio.Existe(id);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _repositorio?.Dispose();

            base.Dispose(disposing);
        }
    }
}
