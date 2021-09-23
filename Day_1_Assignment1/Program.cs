
using System;

namespace Day_1_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;
            Console.WriteLine("Enter input = \n " +
                "1. PrintPattern \n "  +
                "2.LeapYear \n" +
                "3. Spring Season \n" +
                "4.Quadratic equation \n" +
                "5. printNames  ");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {

                case 1:
            PrintPattern p = new PrintPattern();
            p.PrintPatternKWD();
                    break;

                case 2:
            LeapYearOrNot l = new LeapYearOrNot();
            l.CheckLeapYear();
                    break;

                case 3:
                    SpringSeason s = new SpringSeason();
            s.CheckDayAndMonth();
                    break;

                case 4:
             Quadratic q = new Quadratic();
             q.FindRoots();
                    break;


                case 5:
            PrintThreeNames print = new PrintThreeNames();
            print.printNames();
                    break;

                default:
                    Console.WriteLine("Enter valid input ");
                    break;
        }
        }   
    }
}


