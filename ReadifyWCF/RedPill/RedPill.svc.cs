using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RedPill
{
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            return Guid.Parse("35fae189-f25a-485e-8715-3c8ac9e200c7");
        }

        public long FibonacciNumber(long n)
        {
            if (n > 100L || n < 0)
            {
                throw new ArgumentOutOfRangeException("Out of range exception");
            }

            if (n == 0L)
            {
                return 0L;
            }
            if (n == 1)
            {
                return 1L;
            }
            long frstInt = 0;
            long lstInt = 1;
            while (n-- > 1)
            {
                long i = frstInt;
                frstInt = lstInt;
                lstInt += i;
            }
            return lstInt;
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }
            if (a == b && a == c)
            {
                return TriangleType.Equilateral;
            }
            if (a == b || a == c || b == c)
            {
                return TriangleType.Isosceles;
            }
            return TriangleType.Scalene;
        }

        public string ReverseWords(string s)
        {
            string[] splitted = s.Split(' ');
            var reverse = splitted.Select(x => new String(x.Reverse().ToArray()));
            return string.Join(" ", reverse);
        }
    }
}

