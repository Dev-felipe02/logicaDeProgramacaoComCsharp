using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Temporizador
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temporizador com laço de repetição For");

            Console.WriteLine("Digite o valor de hora: ");
            int horaD = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor de minutos: ");
            int minutoD = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor de segundos: ");
            int segundosD = Convert.ToInt16(Console.ReadLine());

            int segundos = 0;
            int minuto = 0;
            int hora = 0;

            for (hora = horaD ; hora > -1; hora--)
            {
                for (minuto = minutoD; minuto > -1; minuto--)
                {
                    for (segundos = segundosD; segundos > -1; segundos--)
                    {
                        Console.WriteLine($"{hora}:{minuto}:{segundos}");
                        
                    }
                    segundosD = 59;
                }
                minutoD = 59;
            }
        }
    }
}