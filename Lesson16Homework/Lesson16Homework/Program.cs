using System;

namespace Lesson16Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day of your birth:");
            int birthday = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of your birthday:");
            int month = int.Parse(Console.ReadLine());
            int count = (new DateTime(DateTime.Now.Year,month, birthday) - DateTime.Now).Days;
            Console.WriteLine($"To your birthday left {count} days");
        }
    }
}
