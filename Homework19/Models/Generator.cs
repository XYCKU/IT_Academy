using System;
using System.Text;

namespace Models
{
    public static class StringGenerator
    {
        private static Random random = new Random();
        private static readonly int maxValue = 'z' - 'a';
        public static string Generate(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; ++i) 
            {
                char next = (char)('a' + random.Next(maxValue));
                sb.Append(next);
            }
            return sb.ToString();
        }
    }
}
