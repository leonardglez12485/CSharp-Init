using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        Console.WriteLine("Enter your birth date (yyyy-MM-dd): ");
        string? input = Console.ReadLine();
        if (DateTime.TryParse(input, out DateTime birthDate))
        {
            DateTime today = DateTime.Today;
            TimeSpan age = today - birthDate;
            int daysLived = (int)age.TotalDays / 365;
            Console.WriteLine($"You have lived for {daysLived} years.");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
        }
    }
    static void DaysUntilNextBirthday()
    {
       Console.WriteLine("Enter your birth date (yyyy-MM-dd): ");
        string? input = Console.ReadLine();
        if(DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate)){
            DateTime today = DateTime.Now.Date;
            DateTime actualBirthdate = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            TimeSpan daysUntilBirthday = actualBirthdate - today;
            if(daysUntilBirthday.TotalDays < 0)
            {
           
                daysUntilBirthday = TimeSpan.FromDays(Math.Abs(daysUntilBirthday.TotalDays));
                Console.WriteLine($"Your birthday was {daysUntilBirthday.Days} days ago.");

            } 
            else
            if (daysUntilBirthday.TotalDays == 0)
            {
                Console.WriteLine($"Happy Birthday! \uD83C\uDF89\uD83C\uDF82");
            }
            else
            {
                Console.WriteLine($"There are {daysUntilBirthday.Days} days until your next birthday.");
            }
            // if (actualBirthdate < today)
            // {
            //     actualBirthdate = actualBirthdate.AddYears(1);
            // }
            // TimeSpan daysUntilBirthday = actualBirthdate - today;
            // Console.WriteLine($"There are {daysUntilBirthday.Days} days until your next birthday.");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
            
        }
        
    }
}