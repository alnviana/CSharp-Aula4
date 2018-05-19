using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Aula4 {
    class Pessoa {
        public string Nome { get; set; }

        public override string ToString() {
            return "Pessoa - Nome: " + this.Nome;
        }
    }
}
