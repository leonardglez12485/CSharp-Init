partial class Program{

    static void SalryCalculator( )
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.Write("Enter your salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the number of hours worked: ");
        double  hoursWorked = Convert.ToDouble(Console.ReadLine());
        double hourlyRate = salary * hoursWorked;
        Console.WriteLine($"Hourly Rate for {name}: {hourlyRate:C}");
    }
}