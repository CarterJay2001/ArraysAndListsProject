﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE!:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[10];
            for(int i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Evens:");
            foreach(var num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nOdds:");
            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }
        }
    }
}
