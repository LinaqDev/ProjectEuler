using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem9 : IProblem
    {
        public string Run()
        {
            return P9();
        }

        //A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,
        //a^2 + b^2 = c^2
        //For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        //Find the product abc.
        private static string P9()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (a + b + c == 1000)
                        {
                            if (a < b && b < c)
                                if ((a*a) + (b*b) == c*c)
                                {
                                    return $"{a} {b} {c} \nProduct: {a*b*c}";
                                }
                        }
                    }
                }
            }
            return $"Not found.";
        }
    }
}
