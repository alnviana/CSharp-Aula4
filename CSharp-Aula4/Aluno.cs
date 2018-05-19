using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Aula4 {
    class Aluno:Pessoa {
        public string MatriculaAluno { get; set; }

        public override string ToString() {
            return "Aluno - Nome: " + this.Nome + " - MatrículaAluno: " + this.MatriculaAluno;
        }
    }
}
