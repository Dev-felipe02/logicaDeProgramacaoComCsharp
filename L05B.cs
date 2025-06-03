using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L05B
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt16(Console.ReadLine());

            for (int multiplicador = 1; multiplicador < 11; multiplicador++)
            {
                int tabuada = num * multiplicador;
                Console.WriteLine($"{num} x {multiplicador} = {tabuada}");
            }
        }
    }
}
