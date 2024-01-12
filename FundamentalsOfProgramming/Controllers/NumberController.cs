using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly INumberService _NumberService;
        public NumberController(INumberService NumberService)
        {
            _NumberService = NumberService;
        }

        [HttpGet]
        public int GetFactorial(int number)
        {
            return _NumberService.GetFactorial(number);
        }

    }
}
