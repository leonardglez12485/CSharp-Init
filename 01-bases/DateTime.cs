partial class Program
{
    static void DisplayDateTime()
    {
        DateTime noy = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime utc = DateTime.UtcNow;
        DateTime dt = new DateTime(2025, 05, 1, 12, 0, 0);
        DateTime aWeekAgo = dt.AddDays(-7);
        DateTime aWeekLater = dt.AddDays(7);
        DateTime aMonthAgo = dt.AddMonths(-1);
        DateTime aMonthLater = dt.AddMonths(1);
        DateTime aYearAgo = dt.AddYears(-1);
        DateTime aYearLater = dt.AddYears(1);
        DateTime aHourAgo = dt.AddHours(-1);
        DateTime aHourLater = dt.AddHours(1);
        DateTime aMinuteAgo = dt.AddMinutes(-1);
        DateTime aMinuteLater = dt.AddMinutes(1);

        Console.WriteLine($"DateTime.Now: {noy}");
        Console.WriteLine($"DateTime.Today: {today}");
        Console.WriteLine($"DateTime.UtcNow: {utc}");
        Console.WriteLine($"DateTime(2025, 05, 1, 12, 0, 0): {dt}");
        Console.WriteLine($"dt.AddDays(-7): {aWeekAgo}");
        Console.WriteLine($"dt.AddDays(7): {aWeekLater}");
        Console.WriteLine($"dt.AddMonths(-1): {aMonthAgo}");
        Console.WriteLine($"dt.AddMonths(1): {aMonthLater}");
        Console.WriteLine($"dt.AddYears(-1): {aYearAgo}");
        Console.WriteLine($"dt.AddYears(1): {aYearLater}");
        Console.WriteLine($"dt.AddHours(-1): {aHourAgo}");
        Console.WriteLine($"dt.AddHours(1): {aHourLater}");
        Console.WriteLine($"dt.AddMinutes(-1): {aMinuteAgo}");
        Console.WriteLine($"dt.AddMinutes(1): {aMinuteLater}");
        Console.WriteLine($"dt.ToString(\"yyyy-MM-dd\"): {dt.ToString("yyyy-MM-dd")}");




    }
}