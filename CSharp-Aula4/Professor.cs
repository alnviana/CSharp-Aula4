using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Aula4 {
    class Professor:Pessoa {
        public string MatriculaProfessor { get; set; }

        public override string ToString() {
            return "Professor - Nome: " + this.Nome + " - MatrículaProfessor: " + this.MatriculaProfessor;
        }
    }
}
