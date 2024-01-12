using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adapters
{
    public class NumberAdapter : INumberAdapter
    {

        public List<int> GetPrimes(int number)
        {
            var primes = new List<int>();

            for (int i = 2; i <= number; i++)
                while (number % i == 0)
                {
                    primes.Add(i);
                    number = number / i;
                }

            string ads = "das";
            ads.ToLower().StartsWith('r');

            return primes;
        }

        public int GetFactorial(int x)
        {
            if (x == 0)
                return 1;
            return x * GetFactorial(x - 1);
        }
    }
}
