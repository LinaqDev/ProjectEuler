using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem4 : IProblem
    {
        public string Run()
        {
            return P4();
        }
        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        /// <returns></returns>
        private static string P4()
        {
            int result = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    if (isPalindromic(i * j))
                        if (result < (i * j))
                            result = i * j;
                }
            }
            return result.ToString();
        }

        private static bool isPalindromic(long l)
        {
            IEnumerable<char> forwards = l.ToString().ToCharArray();
            return forwards.SequenceEqual(forwards.Reverse());
        }
    }
}
