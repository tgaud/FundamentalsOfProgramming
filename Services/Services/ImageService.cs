using Services.Interfaces;

namespace Services.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageAdapter _ImageAdapter;

        public ImageService(IImageAdapter ImageAdapter)
        {
            _ImageAdapter = ImageAdapter;
        }

        public string GenerateDog()
        {
            return _ImageAdapter.GenerateDog();
        }
    }
}
