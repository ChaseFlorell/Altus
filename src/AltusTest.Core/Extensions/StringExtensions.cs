namespace AltusTest.Core.Extensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            var words = input.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.Length > 0)
                {
                    words[i] = string.Concat(word[0].ToString().ToUpper(), word.Substring(1).ToLower());
                }
            }
            return string.Join(" ", words);
        }
    }
}