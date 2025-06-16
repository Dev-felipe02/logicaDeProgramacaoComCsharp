using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Exercícios03Gemini
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para ser invertida: ");
            string palavra = Console.ReadLine();
            Console.WriteLine(palavra.Length);

            string invertida = new string(palavra.Reverse().ToArray()); 
            Console.WriteLine(invertida);

            //Console.Write("Digite uma palavra: ");
            //string palavra = Console.ReadLine();

            //string invertida = "";

            //// Loop que começa do último caractere até o primeiro
            //for (int i = palavra.Length - 1; i > -1; i--)
            //{
            //    invertida += palavra[i];  // Vai adicionando caractere por caractere invertido
            //}

            //Console.WriteLine("Palavra invertida: " + invertida);
        }
    }
}
