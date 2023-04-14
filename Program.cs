using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double Media;

            Console.Write("Insira o valor do Primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor do Segundo numero: ");
            n2 = double.Parse(Console.ReadLine());

            Media = Math.Sqrt(n1 * n2);
            Console.WriteLine("A Média Geométrica dos dois numeros é {0}.", Media);
        }
    }
}
