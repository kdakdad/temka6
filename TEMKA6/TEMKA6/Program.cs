using System;
using System.Globalization;


public class DateTimeParsingExample
{
    public static void Main(string[] args)
    {
        string dateString1 = "2024-11-24";
        string dateString2 = "24.11.2024";
        string dateString3 = "November 24, 2024";
        string dateString4 = "Invalid Date";
        string timeString = "14:30:00";


        // Parse() - простой парсинг (формат по умолчанию)
        try
        {
            DateTime date1 = DateTime.Parse(dateString1);
            Console.WriteLine($"Parse(\"{dateString1}\"): {date1}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Ошибка парсинга \"{dateString1}\" методом Parse()");
        }

        // ParseExact() - парсинг с указанным форматом
        try
        {
            DateTime date2 = DateTime.ParseExact(dateString2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine($"ParseExact(\"{dateString2}\"): {date2}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Ошибка парсинга \"{dateString2}\" методом ParseExact()");
        }

        // TryParse() - попытка парсинга (формат по умолчанию)
        DateTime date3;
        if (DateTime.TryParse(dateString3, out date3))
        {
            Console.WriteLine($"TryParse(\"{dateString3}\"): {date3}");
        }
        else
        {
            Console.WriteLine($"Ошибка парсинга \"{dateString3}\" методом TryParse()");
        }


        // TryParseExact() - попытка парсинга с указанным форматом
        DateTime date4;
        if (DateTime.TryParseExact(dateString3, "MMMM dd, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date4))
        {
            Console.WriteLine($"TryParseExact(\"{dateString3}\"): {date4}");
        }
        else
        {
            Console.WriteLine($"Ошибка парсинга \"{dateString3}\" методом TryParseExact()");
        }

        //Обработка ошибок
        DateTime date5;
        if (DateTime.TryParse(dateString4, out date5))
        {
            Console.WriteLine($"TryParse(\"{dateString4}\"): {date5}");
        }
        else
        {
            Console.WriteLine($"Ошибка парсинга \"{dateString4}\" методом TryParse()");
        }

        //Парсинг времени
        TimeSpan time;
        if (TimeSpan.TryParse(timeString, out time))
        {
            Console.WriteLine($"TryParse(\"{timeString}\"): {time}");
        }
        else
        {
            Console.WriteLine($"Ошибка парсинга \"{timeString}\" методом TryParse()");
        }

        Console.ReadKey();
    }
}
