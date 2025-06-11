using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Professor
    {
        string nome = "Jailson";
        int idade = 40;

        public static void Main(string[] args)
        {
            Professor tecnologia = new Professor();

            Console.WriteLine("O nome do Profesosor é: " + tecnologia.nome);
            Console.WriteLine("A idade do Profesosor é: " + tecnologia.idade);
        }
    }
}
