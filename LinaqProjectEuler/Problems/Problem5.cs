using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem5 : IProblem
    {
        public string Run()
        {
            return P5(20);
        }
         
        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        /// <returns></returns>
        private static string P5(int maxDiv)
        {
            int result = maxDiv;
            while (true)
            {
                if (isDivided())
                    return result.ToString();
                else
                    result++;
            }

            bool isDivided()
            {
                for (int i = maxDiv; i > 1; i--)
                {
                    if (result % i != 0)
                        return false;
                }
                return true;
            }
        }
    }
}
