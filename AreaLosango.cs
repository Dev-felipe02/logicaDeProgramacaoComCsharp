using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class AreaLosango
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Consulte o valor da area de um Logango!");
            Console.WriteLine("Digite o valor da Diaginal Maior: ");
            float diagonalMax = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor da Diagonal Menor: ");
            float diagonalMin = Convert.ToSingle(Console.ReadLine());
            float areaL = diagonalMax * diagonalMin / 2;
            Console.WriteLine($"O valor da area do Losango é: {areaL}");
        }
    }
}
