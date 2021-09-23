using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_Assignment1
{
    class LeapYearOrNot
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Checking leap year");

            int year;
            Console.WriteLine("Enter four digit year = ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 100 != 0) && (year % 400 == 0) || (year % 4 == 0))
            {
                Console.WriteLine("Entered year is a LEAP YEAR");
            }
            else
            {
                Console.WriteLine("Entered year is Not a LEAP YEAR");
            }

            Console.ReadLine();
        }
    }
}
