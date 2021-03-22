using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            float valor, distribuidor, imposto;
            Console.WriteLine("Informe o Valor de fábrica:");
            produto.valor = float.Parse(Console.ReadLine());
            produto.percentdist = produto.valor * 45 / 100;
            produto.imposto = produto.valor * 28 / 100;
            produto.valor = produto.valor + produto.percentdist + produto.imposto;

            Console.WriteLine("Valor Total:" + produto.valor, " Imposto:" + produto.imposto, " Percentual do distribuidor:" + produto.percentdist);
            Console.ReadKey();
        }
    }
}
