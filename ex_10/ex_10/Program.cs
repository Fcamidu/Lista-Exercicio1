﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            double quantidade = double.Parse(Console.ReadLine());

            double valorEmReais = cotacao * quantidade;

            Console.WriteLine($"O valor em reais é: R$ {valorEmReais:F2}");
        }
    }
}
