using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            Console.WriteLine("Exercicio Carros");
            Console.WriteLine("Qtd Carros Vendidos:");
            vendedor.carrosvendidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor total de vendas:");
            vendedor.valorvendas = float.Parse(Console.ReadLine());
            Console.WriteLine("Salario:");
            vendedor.salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Comissão:");
            vendedor.comissao = float.Parse(Console.ReadLine());

            vendedor.total = vendedor.salario + (vendedor.comissao * vendedor.carrosvendidos) + (vendedor.valorvendas / 100) * 5;

            Console.WriteLine("Salario final do vendedor é igual a: " + vendedor.total;
        }
    }
}
