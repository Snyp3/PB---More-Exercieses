﻿using System;

namespace For_Loop__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    Console.WriteLine($"{hour} : {minutes}");
                }
            }
        }
    }
}