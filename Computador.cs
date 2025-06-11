using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Computador
    {
        string memoriaRam = "16GB RAM";
        string processador = "AMD Rayzen 5200G";
        string armazenamento = "SSD Sata 512GB";

        public static void Main(string[] args)
        {
            Computador meuPc = new Computador();

            Console.WriteLine($"A minha Memoria Ram é: {meuPc.memoriaRam}");
            Console.WriteLine($"O meu Processador é: {meuPc.processador}");
            Console.WriteLine($"O meu Armazenamento é: {meuPc.armazenamento}");
        }
    }
}
