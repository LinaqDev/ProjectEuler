using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem7 : IProblem
    {
        public string Run()
        {
            return P7();
        }

        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10 001st prime number?
        /// </summary>
        /// <returns></returns>
        private static string P7()
        {

            bool isPrime(int number)
            {

                if (number == 1) return false;
                if (number == 2) return true;

                var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

                for (int i = 2; i <= limit; ++i)
                {
                    if (number % i == 0) return false;
                }

                return true;

            }

            int count = 1;
            int result = 1;
            while (count <= 10001)
            {
                result++;
                if (isPrime(result))
                    count++;
            }
            return result.ToString();
        }
    }
}
