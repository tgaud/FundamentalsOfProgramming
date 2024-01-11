using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class NumberService : INumberService
    {

        private readonly INumberAdapter _adapter;
        public NumberService(INumberAdapter adapter)
        {
            _adapter = adapter;
        }
        public List<int> GetPrimes (int number)
        {
            return _adapter.GetPrimes(number); 
        }
    }
}
