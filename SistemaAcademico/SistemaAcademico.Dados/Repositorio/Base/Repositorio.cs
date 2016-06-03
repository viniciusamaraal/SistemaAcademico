using SistemaAcademico.Dados.Contrato;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.Repositorio.Base
{
    public class Repositorio<T> : IDisposable where T : Dominio.Base.Dominio
    {
        protected IContexto db;
        protected internal DbSet<T> dbSet;

        public Repositorio() : this(ContextoFactory.CriaContexto())
        {
        }

        public Repositorio(IContexto db)
        {
            this.db = db;
            dbSet = db.Set<T>();
        }

        public virtual IEnumerable<T> Buscar()
        {
            return dbSet;
        }

        public virtual T Buscar(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Editar(T entidade)
        {
            db.Entry(entidade).State = EntityState.Modified;
        }

        public virtual void Inserir(T entidade)
        {
            dbSet.Add(entidade);
        }

        public virtual void Excluir(int id)
        {
            var entidade = dbSet.Find(id);
            dbSet.Remove(entidade);
        }

        public virtual bool Existe(int id)
        {
            return dbSet.Any(e => e.Id == id);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
