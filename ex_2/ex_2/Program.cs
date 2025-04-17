using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int area;

            Console.Write("Informe o valor da aresta:");
            aresta = int.Parse(Console.ReadLine());

            area = aresta * aresta;

            Console.WriteLine("O valor da area é:" + area);   

        }
    }
}
