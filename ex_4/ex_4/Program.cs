using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            double bas3;
            double altura;

            Console.Write("Digite a base do triangulo:");
            bas3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do triangulo:");
            altura = double.Parse(Console.ReadLine());

            area = bas3 * altura / 2;

            Console.WriteLine("A area do triangulo é:" + area);

        }
    }
}
