using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface INumberAdapter
    {

        abstract List<int> GetPrimes(int number);
        abstract int GetFactorial(int number); 
    }
}
