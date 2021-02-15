using System;
using System.Collections.Generic;

namespace Prime_Factorization
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (; ; ) {
                Console.Write("Please enter a positive number or 0 to quit. ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("The number must be positive ");
                }
                else if (x == 0)
                {
                    Console.Write("Goodbye!");
                    break;
                }
                else if (x == 1) {
                    Console.WriteLine($"The prime factorization of {x} is: 1");
                }
                else
                {
                    Console.Write($"The prime factorization of {x} is: ");
                    while (x % 2 == 0)
                    {
                        Console.Write(2 + " ");
                        x /= 2;
                    }
                    for (int i = 3; i <= Math.Sqrt(x); i += 2)
                    {
                        while (x % i == 0)
                        {
                            Console.Write($"{i} ");
                            x /= i;
                        }
                    }
                    if (x > 1)
                    {
                        Console.Write(x);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
           }
         }
    }

