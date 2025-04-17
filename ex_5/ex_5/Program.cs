using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            double nota1;
            double nota2;
            double nota3;
            double nota4;

            Console.Write("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota:");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota:");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A media da suas notas é:" + media);


        }
    }
}
