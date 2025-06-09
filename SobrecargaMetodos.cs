using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class SobrecargaMetodos
    {
        static int MetodoSomaComNumerosInteiros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static float MetodoSomaComNumerosFlutuantes(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("A soma dos numeros é: " + MetodoSomaComNumerosInteiros(5, 10));
            Console.WriteLine("A soma dos numeros é: " + MetodoSomaComNumerosFlutuantes(5.3F, 6.4F));
        }
    }
}
