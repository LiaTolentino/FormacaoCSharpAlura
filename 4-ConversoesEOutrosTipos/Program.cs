﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 3000.15;
            Console.WriteLine(salario);

            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            long x = 2000000000000000000;
            Console.WriteLine(x);

            short y = 15000;
            Console.WriteLine(y);

            float altura = 1.62f;
            Console.WriteLine(altura);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
