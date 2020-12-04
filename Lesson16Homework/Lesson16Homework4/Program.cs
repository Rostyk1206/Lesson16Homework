using System;

namespace Lesson16Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            accauntant.AskForBonus(Employees.Babysitter, 30);
            accauntant.AskForBonus(Employees.Boss, 60);
            accauntant.AskForBonus(Employees.Cashier, 10);
            accauntant.AskForBonus(Employees.Engineer, 50);
        }
    }
}