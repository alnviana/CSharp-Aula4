using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Aula4 {
    class Program {
        static void Main(string[] args) {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa pessoa = new Pessoa() { Nome = "Fulano" };
            pessoas.Add(pessoa);

            Professor professor = new Professor() {
                Nome = "Beltrano",
                MatriculaProfessor = "123-BCA"
            };
            pessoas.Add(professor);

            Aluno aluno = new Aluno() {
                Nome = "Sicrano",
                MatriculaAluno = "312-BCA"
            };
            pessoas.Add(aluno);

            Pessoa outraPessoa = new Professor() {
                Nome = "Jhon Doe",
                MatriculaProfessor = "321-TRC"
            };
            pessoas.Add(outraPessoa);

            Professor outraPessoaProfessor = (Professor) outraPessoa;

            foreach (var p in pessoas) {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }
    }
}
