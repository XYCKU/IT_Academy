using System;
using System.Linq;

namespace Models
{
    public static class StringExtension
    {
        private static Random random = new Random();
        public static string Shuffle(this string str)
        {
            
            return new string(str.ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());
        }
    }
}
