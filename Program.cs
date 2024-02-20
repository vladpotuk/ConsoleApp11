using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть дату (у форматі dd.mm.yyyy): ");
        string inputDate = Console.ReadLine();

        string[] dateParts = inputDate.Split('.');
        int day = Convert.ToInt32(dateParts[0]);
        int month = Convert.ToInt32(dateParts[1]);
        int year = Convert.ToInt32(dateParts[2]);
        string season = GetSeason(month);

        string dayOfWeek = GetDayOfWeek(new DateTime(year, month, day));

        
        Console.WriteLine($"{season} {dayOfWeek}");
    }

    
    static string GetSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                return "Unknown";
        }
    }

    static string GetDayOfWeek(DateTime date)
    {
        return date.ToString("dddd");
    }
}

