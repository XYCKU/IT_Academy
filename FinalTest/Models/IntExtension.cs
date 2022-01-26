using System;
using System.Text;

namespace Models
{
    public static class IntExtension
    {
        private static readonly string[] numbers = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        public static string ToWords(this int number)
        {
            string num = number.ToString();
            StringBuilder sb = new StringBuilder(numbers[num[0] - '0']);
            for(int i = 1; i < num.Length; ++i)
            {
                sb.Append($" {numbers[num[i] - '0']}");
            }
            return sb.ToString(); 
        }
    }
}
