using System;
using System.Globalization;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTimeTemplate = "d-M-yyyy";
            var inputDate = Console.ReadLine();
            var date = DateTime.ParseExact(inputDate, dateTimeTemplate, CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
