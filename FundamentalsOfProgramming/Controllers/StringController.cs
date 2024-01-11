using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class StringController : ControllerBase
    {
        private readonly IStringService _StringService;
        public StringController(IStringService StringService)
        {
            _StringService = StringService;
        }
        [HttpGet]
        public string ReverseString(string text)
        {
            return _StringService.ReverseString(text);
        }
    }
}
