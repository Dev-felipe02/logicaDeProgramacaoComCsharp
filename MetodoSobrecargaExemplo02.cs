using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class MetodoSobrecargaExemplo02
    {
       static int Soma(int valor1, int valor2)
       {
          return valor1 + valor2;
       }
            
       static double Soma(double valor1, double valor2)
        {
          return valor1 + valor2;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor");
            double num01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            double num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A soma dos numeros é: {Soma(num01, num02)}");
        }
            
    }
}
