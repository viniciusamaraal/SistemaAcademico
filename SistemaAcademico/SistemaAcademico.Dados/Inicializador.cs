using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados
{
    public class Inicializador : DropCreateDatabaseAlways<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var curso = new List<Curso>
            {
                new Curso { Nome = "Ciência da Computação" },
                new Curso { Nome = "Engenharia da Computação" },
                new Curso { Nome = "Engenharia de Software" },
                new Curso { Nome = "Sistemas de Informação" },
            };

            curso.ForEach(c => contexto.Curso.Add(c));
            contexto.SaveChanges();
        }
    }
}

