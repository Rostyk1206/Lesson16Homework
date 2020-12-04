using System;

namespace Lesson16Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your text:");
            string str = Console.ReadLine();
            Console.WriteLine("Choose your flowers:1.Rose; 2.Tulip; 3.Orchid; 4.Lily");
            int color = int.Parse(Console.ReadLine());
            BaseClass.Print(str, color);
        }
    }
}

