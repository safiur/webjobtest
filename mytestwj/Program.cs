﻿using System;
using System.Threading.Tasks;

namespace mytestwj
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine($"Continuous Job Running {++n}");
                await Task.Delay(2000);
            }

        }
    }
}