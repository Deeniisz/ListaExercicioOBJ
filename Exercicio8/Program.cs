using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            Console.WriteLine("--APP 'é triangulo'--");
            Console.WriteLine("*Informe o valor dos lados*");
            Console.WriteLine("Informe o Primeiro lado:");
            tri.lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo lado:");
            tri.lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Terceiro lado:");
            tri.lado3 = int.Parse(Console.ReadLine());
            
            if(tri.lado1 > tri.lado2 + tri.lado3 || tri.lado2 > tri.lado1 + tri.lado3 || tri.lado3 > tri.lado1 + tri.lado2)
            {
                Console.WriteLine("Não é um triangulo");
            }
            else
            {
                Console.WriteLine("É um triangulo");
            }
        }
    }
}
