using System;

namespace Entities
{
    public static class DateTimeExtension
    {
        public static string GetFromWorldCreation(this DateTime dateTime)
        {
            var dt = dateTime.AddYears(5501);
            return $"День {dt.Day} месяца ‘{dt.Month}’ года {dt.Year} от сотворения мира.";
        }
    }
}
