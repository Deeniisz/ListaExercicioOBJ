using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("APP Peso ideal");
            Console.WriteLine("Nome:");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Altura:");
            pessoa.altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Sexo (M ou F):");
            pessoa.sexo = Console.ReadLine();
            pessoa.pesoideal = 0;
            if (pessoa.sexo == "m" || pessoa.sexo == "M")
            {
                pessoa.pesoideal = (72.7 * pessoa.altura) - 58;
            }
            else
            {
                if (pessoa.sexo == "F" || pessoa.sexo == "f")
                {
                    pessoa.pesoideal = (62.1 * pessoa.altura) - 44.7;
                }
                else
                {
                    Console.WriteLine("***ERRO***");
                }
            }
            Console.WriteLine("O peso ideal de" + pessoa.nome + "é:" + pessoa.pesoideal);


            Console.ReadKey();
        }
    }
}
