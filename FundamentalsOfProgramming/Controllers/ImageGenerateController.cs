using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageGenerateController : ControllerBase
    {
        private readonly ImageService _ImageService;
        public ImageGenerateController(ImageService ImageService)
        {
            _ImageService = ImageService;
        }

        [HttpGet]
        public string GenerateDogImage()
        {
            return _ImageService.GenerateDog();
        }

    }
}
