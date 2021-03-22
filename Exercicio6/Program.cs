using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            Console.WriteLine("Vendedor de Empresa X");
            Console.WriteLine("Salario:");
            vendedor.salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor total das vendas:");
            vendedor.valorvendas = float.Parse(Console.ReadLine());
            vendedor.total = 0;
            if (vendedor.valorvendas <= 1500)
            {
                vendedor.total = vendedor.valorvendas + (vendedor.valorvendas / 100) * 3;
            }
            else
            {
                vendedor.total = (1500 + (1500 / 100) * 3) + ((vendedor.valorvendas - 1500) + (vendedor.valorvendas - 1500) / 100 * 5);
            }

            Console.WriteLine("Salário total é:" + vendedor.total);

            Console.ReadKey();
        }
    }
}
