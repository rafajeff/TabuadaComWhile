﻿using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 0;

            Console.WriteLine("Digite um número do qual você quer saber a tabuada");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            while (i <= 10 ) 
            {
                Console.WriteLine($"{n} X {i} = { i* n}");
                i++;

            }
            
        }
    }
}
