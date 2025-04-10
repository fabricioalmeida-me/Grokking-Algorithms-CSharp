using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factorial
{
    public class FactorialAlgorithm
    {
        public static int Fact(int n)
        {
            if (n <= 1) return 1;

            return n * Fact(n - 1);
        }
    }
}