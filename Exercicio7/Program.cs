using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
                Numero n1 = new Numero();
                Numero n2 = new Numero();
                Numero n3 = new Numero();
                Console.WriteLine("--Maior Numero--");
                Console.WriteLine("*Informe Números Diferentes*");
                Console.WriteLine("Informe o Primeiro Numero:");
                n1.numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Segundo Numero:");
                n2.numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Terceiro Numero:");
                n3.numero = int.Parse(Console.ReadLine());
                int maior = n1.numero, menor = n1.numero;
                if (n2.numero > maior)
                {
                    maior = n2.numero;
                }
                if (n3.numero > maior)
                {
                    maior = n3.numero;
                }
                if (n2.numero < menor)
                {
                    menor = n2.numero;
                }
                if (n3.numero < menor)
                {
                    menor = n3.numero;
                }
        }
    }
}
