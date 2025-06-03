using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class AreaQuadrado
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculo Area de um quadrado");
            Console.WriteLine("Digite o valor da Base: ");
            float baseq = Convert.ToSingle(Console.ReadLine());
            float area = baseq * baseq;
            Console.WriteLine($"O valor da Base do quadrado é: {area}");
        }
    }
}
