using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class AreaRetangulo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Consultar Area de um Retangulo!");
            Console.WriteLine("Digite o valor da Base: ");
            float baseR = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor da Altura: ");
            float alturaR = Convert.ToSingle(Console.ReadLine());
            float areaR = Convert.ToSingle(baseR * alturaR);
            Console.WriteLine($"O valor da area do Retangulo é: {areaR}");
        }
    }
}
