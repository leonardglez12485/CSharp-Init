partial class Program{
    static void HandleNullable()
    {
        string? apellido = null;
        string name2 = "John";
        string name3 = apellido ?? "No Last Name";
        Console.WriteLine($"{name2} {name3}");
    }
}