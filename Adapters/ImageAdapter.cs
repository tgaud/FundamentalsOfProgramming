using Services.Interfaces;

namespace Adapters
{
    public class ImageAdapter : IImageAdapter
    {
        public ImageAdapter() { }

        public string GenerateDog()
        {
          
            return "https://images.dog.ceo/breeds/hound-ibizan/n02091244_939.jpg";
        }
    }
}
