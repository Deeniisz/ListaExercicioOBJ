using Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int a, m, d, final;
            Idade idade = new Idade();

            Console.WriteLine("Informe a idade:");
            Console.WriteLine("Anos:");
            idade.Anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Meses:");
            idade.Meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Dias:");
            idade.Dias = int.Parse(Console.ReadLine());

             = 

            final = idade.Anos * 365 + idade.Meses * 30 + idade.Dias;

            Console.WriteLine("Idade em dias é igual a:" + idade);


            Console.ReadKey();

        }
    }
}
