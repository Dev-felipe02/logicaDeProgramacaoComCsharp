using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExemploVetor
    {
        public static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            //Substituir valor em Vetor

            cars[1] = "Chevrollet";
            Console.WriteLine(cars[1]);

            //Length

            Console.WriteLine(cars.Length);
        }
    }
}
