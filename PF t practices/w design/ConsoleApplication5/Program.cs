﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                
                    Console.Write("*");


                    for (int a = 6; a >= i; a--)
                    {

                        Console.Write("  ");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("  ");
                    }

                    Console.Write("*");


                        for (int a = 6; a >= i; a--)
                        {

                            Console.Write("  ");
                        }

                        Console.Write("*");

                    Console.WriteLine();
                }
            }
        }
    }

