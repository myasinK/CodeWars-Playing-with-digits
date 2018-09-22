using System;
using System.Linq;

namespace Kata_PlayingWithDigits
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            var m = CalcSumOfPowers(n, p);
            return (m % n == 0) ? (long)m / n : -1;
        }

        public static int CalcSumOfPowers(int n, int p)
        {
            var nList = n.ToString().ToList();
            int sum = 0;
            foreach (var c in nList)
            {
                var cToNum = char.GetNumericValue(c);
                sum += (int)Math.Pow(cToNum, p);
                p++;
            }

            Console.WriteLine(sum);
            return sum;
        }
    }
}
