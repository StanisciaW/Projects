using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration 
            int x, y, a, b;

            // Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // Mathematical operators


            // Addition operator
            x = 3 + 4;

            // subtraction operator
            x = 4 - 3;

            // Multipication operator
            x = 10 * 5;

            // Division operator
            x = 10 / 5;

            // order of operations using parentesis
            x = (x + y) * (a - b);


            // Operators used to evaluate values

            // Equality operator
            if (x == y)
            {

            }

            // Greater than operator
            if (x > y)
            {

            }


            // Less than operator
            if (x < y)
            {

            }

            // Greater than equal to operator

        if (x >= y)
            {

            }
        if (x <= y)
            {

            }

        // there are two "conditional" operators as well that can be used to expand / enhance an evaluation and they can be cpmbined together multiple times.

            // Conditional AND operator
            if ((x > y) && (a > b))
            {

            }



            // Conditional OR operator
            if ((x > y) || (a > b))
            {

            }


            // Also, heres the in line conditional operator 
            string message = (x == 1) ? "Car" : "Boat";

            // Message access and method invocation
            Console.WriteLine("Hi");


        }
    }
}
