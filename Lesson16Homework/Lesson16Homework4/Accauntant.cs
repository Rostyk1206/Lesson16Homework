using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16Homework4
{
    class Accauntant
    {
        public bool AskForBonus(Employees employee, int hours)
        {
            //string j =employee.ToString();
            if (hours > (int)employee)
            {
                Console.WriteLine($"{employee} can take bonus");
                return true;
            }
            else
            {
                Console.WriteLine($"{employee} cannot take bonus");
                return false;
            }
        }
    }
}
