using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} = {x+y}");
            double output = x + y;
            return output;
            // return x + y; another way of shortening the previous verbose code
        }

        public static void AddAll(double[] values)
        {
            double result = 0;
            // values.Sum(); also is a built in function to do this for us instead of a foreach loop
            foreach (double value in values) 
            {
                result += value;
            }

            Console.WriteLine($"The total is {result}");
        }
    }
}
