using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario = 0, maior = 0, total = 0, filhos = 0, menor = 0, totalfilhos = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Salario do habitante nº" + (n + 1));
                salario = Console.ReadLine();
                Console.WriteLine("Numero de Filhos do habitante nº" + (n + 1));
                filhos = Console.ReadLine();
                totalfilhos = totalfilhos + filhos;
                total = total + salario;
                if (salario > maior)
                {
                    maior = salario;
                }
                if (salario < 150)
                {
                    menor++;
                }
            }
            Console.WriteLine("a media entre os salarios é:" + total / 4);
            Console.WriteLine("a media do numero de filhos é:" + totalfilhos / 4);
            Console.WriteLine("O maior salario é:" + maior);
            Console.WriteLine("Percentual de salarios menores que 150 é:" + (menor / 4) * 100);
            Console.ReadKey();
        }
    }
}
