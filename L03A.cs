using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L03A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero e descubra a tabuada dele: ");
            int num = Convert.ToInt16(Console.ReadLine());
            int i = 1;

            while (i < 11)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
                i++;
            }
        }
    }
}
