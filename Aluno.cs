using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Aluno
    {
        public string IdadeAluno;

        public Aluno(string idade)
        {
            IdadeAluno = idade;     
        }

        public static void Main(string[] args)
        {
            Aluno felipe = new Aluno("28");
            Console.WriteLine(felipe.IdadeAluno);
        }
    }
}
