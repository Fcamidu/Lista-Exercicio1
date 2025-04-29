using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            double y = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(x, y);

            Console.WriteLine($"{x} elevado a {y} é igual a {resultado}");
        }
    }
}
