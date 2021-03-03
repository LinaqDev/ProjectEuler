using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem6 : IProblem
    {
        public string Run()
        { 
            return P6(100); 
        } 

        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// 1^2 + 2^2 + ... + 10^2 = 385
        /// The square of the sum of the first ten natural numbers is,
        /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        /// <returns></returns>
        private static string P6(int num)
        {
            double sumOfSquares()
            {
                double sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += Math.Pow(i, 2);
                }
                return sum;
            }

            double SquareOfSum()
            {
                double sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                return Math.Pow(sum, 2);
            }

            return $"{ SquareOfSum() - sumOfSquares()}";
        }
    }
}
