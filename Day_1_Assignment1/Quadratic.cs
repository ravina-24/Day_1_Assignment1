using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_Assignment1
{
    class Quadratic
    {

        public void FindRoots()
        {


            int a, b, c;

            Console.WriteLine("Enter the value of a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b = ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of c = ");
            c = Convert.ToInt32(Console.ReadLine());

            double delta = (b * b - 4 * a * c);
            double root1, root2;

            if (delta > 0)
            {
                root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                root2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Both roots are real {0} , {1}", +root1 + root2);
            }
            else if (delta == 0)
            {
                root1 = root2 = -b / (2 * a);

                Console.WriteLine("Roots are equal ");
            }
            else
            {
                Console.WriteLine("Roots are imaginary");
            }


            Console.ReadLine();

        }

    }
}
