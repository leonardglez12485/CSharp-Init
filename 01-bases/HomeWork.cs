partial class Program{
    static void Salesreport(){
        string producto = "Laptop";
        int quantity = 3;
        double price = 750.99;
        double totalAmount = quantity * price;
        Console.WriteLine($"Product: {producto}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Total Amount of Sales : {totalAmount:C}");
       }
}