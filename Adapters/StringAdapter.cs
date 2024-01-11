using Services.Interfaces;

namespace Adapters
{
    public class StringAdapter : IStringAdapter
    {
        public string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
