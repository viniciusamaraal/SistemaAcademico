﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey(nameof(Usuario))]
        public int IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }

        public ICollection<AlunoAtividade> AlunoAtividades { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}  
