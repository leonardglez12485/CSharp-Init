partial class Program {
    static void StringType(){
        string name = "John Doe";
        string address = "123 Main St, Anytown, USA";
        string phoneNumber = "555-1234";
        string email = "john@gmail.com";
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Phone Number: {phoneNumber}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine("--------------------");
        Console.WriteLine("String Concatenation");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Tu nombre tiene {name.Length} caracteres");
        Console.WriteLine($"Tu nombre en mayúsculas es {name.ToUpper()}");

    }
}