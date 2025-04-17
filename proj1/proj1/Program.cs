using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bas3;
            int altura;
            int area;

            Console.Write("informe o valor da base do retangulo:");
            bas3 = int.Parse(Console.ReadLine());

            Console.Write("informe o valor da altura do retangulo:");
            altura = int.Parse(Console.ReadLine());

            area = bas3 * altura;

            Console.WriteLine("a area de seu retangulo é:" + area);
        }
    }
}
