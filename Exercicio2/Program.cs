using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Votos votos = new Votos();
            int validos;
            Console.WriteLine("Exercício Eleitores");
            Console.WriteLine("Qtd Eleitores:");
            votos.Total = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos Brancos:");
            votos.Branco = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos Nulos:");
            votos.Nulo = int.Parse(Console.ReadLine());

            validos = ((votos.Total - votos.Branco - votos.Nulo) / 100 * votos.Total);

            votos.Branco = (votos.Branco / 100 * votos.Total);

            votos.Nulo = (votos.Nulo / 100 * votos.Total);

            Console.WriteLine("% Validos:" + validos);
            Console.WriteLine("% Brancos:" + votos.Branco);
            Console.WriteLine("% Nulos:" + votos.Nulo);

            Console.ReadKey();

        }
    }
}
