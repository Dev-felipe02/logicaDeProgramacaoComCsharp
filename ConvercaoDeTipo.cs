using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ConvercaoDeTipo
    {
        public static void Main(string[] args)
        {
            int inteiro = 10;
            double real = 2.51;
            bool booleano = true;

            Console.WriteLine(Convert.ToString(inteiro));
            Console.WriteLine(Convert.ToDouble(inteiro));
            Console.WriteLine(Convert.ToInt32(real));
            Console.WriteLine(Convert.ToString(booleano));
        }
    }
}
