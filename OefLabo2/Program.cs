﻿using System;

namespace OefLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0;i<10;i++){
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
