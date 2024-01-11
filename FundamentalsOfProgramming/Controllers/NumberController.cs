using Adapters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly INumberAdapter _adapter;
        public NumberController(INumberAdapter adapter)
        {
            _adapter = adapter;
        }

        [HttpGet]
        public List<int> GetPrimes(int number)
        {
            return _adapter.GetPrimes(number);
        }

    }
}
