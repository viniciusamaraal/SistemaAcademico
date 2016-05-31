using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Sandbox
{
    public class CompetenciaGrupo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Competencia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCompetenciaGrupo { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var competencias = new List<Competencia>();
            competencias.Add(new Competencia() { Id = 1, Nome = "Competencia 04", IdCompetenciaGrupo = 2 });
            competencias.Add(new Competencia() { Id = 2, Nome = "Competencia 03", IdCompetenciaGrupo = 1 });
            competencias.Add(new Competencia() { Id = 3, Nome = "Competencia 02", IdCompetenciaGrupo = 2 });
            competencias.Add(new Competencia() { Id = 4, Nome = "Competencia 01", IdCompetenciaGrupo = 2 });

            foreach (var group in competencias.GroupBy(item => item.IdCompetenciaGrupo))
            {
                Console.WriteLine(group.Key);
                foreach (var item in group.OrderBy(x => x.Nome))
                {
                    Console.WriteLine("\t" + item.Nome);
                }
            }
        }
    }
}
