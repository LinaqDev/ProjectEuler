using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem1 : IProblem
    {
        public string Run()
        {
            return P1(1000);
        }

        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        private string P1(int max)
        {
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum.ToString();
        }
    }
}
