using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Antecessor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero e descubra o Antecessor!");
            Console.WriteLine("Digite um numero: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            int Antecessor = num1 - 1;
            Console.WriteLine($"O antecessor do numero digitado é {Antecessor}");
        }
    }
}
