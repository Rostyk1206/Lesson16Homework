using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16Homework3
{
    class BaseClass
    {
        public static void Print(string str, int color)
        {
            switch(color)
            {
                case 1:
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Your flower is {Flowers.Rose}");
                        Console.WriteLine($"{str}");
                        break;
                    }
                case 2:
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Your flower is {Flowers.Tulip}");
                        Console.WriteLine($"{str}");
                        break;
                    }
                case 3:
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Your flower is {Flowers.Orchid}");
                        Console.WriteLine($"{str}");
                        break;
                    }
                case 4:
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine($"Your flower is {Flowers.Lily}");
                        Console.WriteLine($"{str}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect number");
                        break;
                    }
            }
            
        }
    }
}
