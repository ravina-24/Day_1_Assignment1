using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_Assignment1
{
    class SpringSeason
    {

        public void CheckDayAndMonth()
        {
            int date, month;

            Console.WriteLine("Checking date and month \n");
            

            Console.WriteLine("Enter date = ");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month = ");
            month = Convert.ToInt32(Console.ReadLine());

            if ((date <=20 || month  <= 3 ) && (date >=20 || month <=6 ) && (date <=31))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();
        }
        
    }
}
