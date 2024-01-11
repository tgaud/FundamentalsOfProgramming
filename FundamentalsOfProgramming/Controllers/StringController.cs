using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class StringController : ControllerBase
    {
        private readonly IStringAdapter _StringAdapter;
        public StringController(IStringAdapter ImageAdapter)
        {
            _StringAdapter = ImageAdapter;
        }
        [HttpGet]
        public string ReverseString(string text)
        {
            return _StringAdapter.ReverseString(text);
        }
    }
}
