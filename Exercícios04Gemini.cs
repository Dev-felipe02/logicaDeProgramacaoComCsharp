using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Exercícios04Gemini
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra e veja quantas vogais ela tem");
            string palavra = Console.ReadLine();
            palavra = palavra.ToLower();
            int contador = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' || palavra[i] == 'o' || palavra[i] == 'u')
                {
                    contador++;
                }
            }
            Console.WriteLine($"O numero de vogais nessa palavra é igual á: {contador}");
        }
    }
}
