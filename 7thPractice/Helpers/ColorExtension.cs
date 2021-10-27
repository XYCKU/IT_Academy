using Models;
using System;
using System.Text;

namespace Helpers
{
    public static class ColorExtension
    {
        public static string BuildColorLongName(this Colors color, string textValue)
        {
            var builder = new StringBuilder();
            builder.Append(textValue);
            builder.Append(color.ToString());

            return builder.ToString();
        }
    }
}
