﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class IfTernario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo if Ternario");
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            string verificar = (idade < 18) ? "Não pode entar." : "Pode Entrar.";
            Console.WriteLine(verificar);
        }
    }
}
