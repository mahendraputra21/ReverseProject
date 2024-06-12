using Domain;

namespace Application
{
    public class ReverseStringService : IReverseStringService
    {
        public string GetReverseString(string inputString)
        {
            var result = new ReverseString(inputString);
            return result.ProcessingReverseString();
        }
    }
}
