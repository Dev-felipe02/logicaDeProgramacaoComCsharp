using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class SobrecargaMetodos
    {
        static int MetodoSoma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static float MetodoSoma(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("A soma dos numeros é: " + MetodoSoma(5, 10));
            Console.WriteLine("A soma dos numeros é: " + MetodoSoma(5.3F, 6.4F));
        }
    }
}
