using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class StringService
    {
        private readonly IStringAdapter _adapter;
        public StringService(IStringAdapter adapter)
        {
            _adapter = adapter;
        }
        public string ReverseString(string text)
        {
            return _adapter.ReverseString(text);
        }

    }
}
