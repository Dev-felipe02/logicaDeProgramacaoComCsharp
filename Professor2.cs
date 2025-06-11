using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Professor2
    {
        string nome = "Marcio";
        string nacionalidade = "brasileira";
        string estado = "SP";

        public static void Main(string[] args)
        {
            Professor2 professor = new Professor2();
            Professor2 professor2 = new Professor2();

            Console.WriteLine($"O estado do primeiro Professor é: {professor.estado}");
            Console.WriteLine($"A nacionalidade do segundo Professor é: {professor2.nacionalidade}");
        }
    }
}
