using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Exercícios05Gemini
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada usando Matriz, de 1 á 10");
            int i, j;

            int[,] num = new int[10, 10];

            for (i = 0; i < num.GetLength(0); i++)
            {
                for (j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = (i + 1) * (j + 1);
                    Console.WriteLine(num[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
