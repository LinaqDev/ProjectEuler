using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler.Problems
{
    public class Problem12 : IProblem
    {
        public string Run()
        {
            return P12();
        }

        private string P12()
        {
            int number = 0;
            for (int i = 1; ; i++)
            {
                number += i; // number is triangle number i
                if (CountDivisorsOfNumber(number) > 500)
                    return number.ToString();
            }
        }

        private int CountDivisorsOfNumber(int number)
        {
            int count = 0;
            int end = (int)Math.Sqrt(number);
            for (int i = 1; i < end; i++)
            {
                if (number % i == 0)
                    count += 2;
            }
            if (end * end == number) // Perfect square
                count++;
            return count;
        }
    }
}