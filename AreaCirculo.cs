using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class AreaCirculo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Consulte a area de um circulo!");
            Console.WriteLine("Digite o valor do Raio: ");
            float raioC = Convert.ToSingle(Console.ReadLine());
            float areaC = (float)(3.14 * (raioC * raioC));
            Console.WriteLine($"O valor da are do Circulo é: {areaC}");
        }
    }
}
