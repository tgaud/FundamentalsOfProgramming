using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageGenerateController : ControllerBase
    {
        private readonly IImageAdapter _imageAdapter;
        public ImageGenerateController(IImageAdapter ImageAdapter)
        {
            _imageAdapter = ImageAdapter;
        }

        [HttpGet]
        public string GenerateDogImage()
        {
            return _imageAdapter.GenerateDog();
        }

    }
}
