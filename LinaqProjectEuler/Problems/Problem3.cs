using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem3 : IProblem
    {
        public string Run()
        { 
            return P3(600851475143); 
        }


        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        /// <returns></returns>
        private static string P3(long x)
        {
            int i, e;
            i = 2;
            e = (int)Math.Sqrt(x);
            while (i <= e)
            {
                while ((x % i) == 0)
                {
                    x /= i;
                    e = (int)Math.Sqrt(x);
                }
                i++;
            }

            return x.ToString();
        }
    }
}
