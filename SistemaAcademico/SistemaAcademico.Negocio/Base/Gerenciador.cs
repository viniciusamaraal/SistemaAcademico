using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Base;
using SistemaAcademico.Dados.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Base
{
    public class Gerenciador<T> : IDisposable where T: Dominio.Base.Dominio
    {
        protected readonly Adaptador adaptador;

        public Gerenciador()
        {
            this.adaptador = new Adaptador();
        }

        public Gerenciador(Adaptador adaptador)
        {
            this.adaptador = adaptador;
        }

        public Gerenciador(IContexto contextoExistente)
        {
            this.adaptador = new Adaptador(contextoExistente);
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
                }

                return _repositorio;
            }
        }

        public IEnumerable<T> Buscar()
        {
            return Repositorio.Buscar();
        }

        public T Buscar(int id)
        {
            return Repositorio.Buscar(id);
        }

        public void Editar(T entidade)
        {
            Repositorio.Editar(entidade);
            adaptador.SalvarAlteracoes();
        }

        public void Inserir(T entidade)
        {
            Repositorio.Inserir(entidade);
            adaptador.SalvarAlteracoes();
        }

        public void Excluir(int id)
        {
            Repositorio.Excluir(id);
            adaptador.SalvarAlteracoes();
        }

        public bool Existe(int id)
        {
            return Repositorio.Existe(id);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
                Repositorio.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
