using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String n;
            int maior = 0, total = 0;
           
            for (int i = 0; i < 15; i++)
            {
                string n;
                Numero n = new Numero();
                Console.WriteLine("Informe o valor do valor nº" + i+1);
                n = Console.ReadLine();
                total = total + n;
                if (n > maior)
                {
                    maior = n;
                }

            }
            Console.WriteLine("O Maior valor é:" + maior);
            Console.WriteLine("A media entre os 15 numeros é igual a:" + total / 15);
            Console.ReadKey();
        }
    }
}
