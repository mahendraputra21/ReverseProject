namespace Domain
{
    public class ReverseString
    {
        private const int maxString = 5;

        public string? InputString { get; private set; }

        public ReverseString(string? inputString)
        {
            InputString = inputString;
        }

        public string ProcessingReverseString()
        {
            if (InputString == null) return string.Empty;

            if (InputString.Length > maxString)
            {
                var charArry = InputString?.ToCharArray();

                string reverseString = string.Empty;

                for (int i = InputString!.Length - 1; i >= 0; i--)
                {
                    reverseString += charArry![i];
                }

                return reverseString ?? "";
            }

            return InputString;
        }
    }
}
