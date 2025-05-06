partial class Program
{
    static void Inventory()
    {
        string[] products = ["Monitor", "Keyboard", "Mouse"];
        double[] prices = [250.50, 25.50, 45.00];
        int[] stock = [10, 25, 30];
        Console.WriteLine("Product on Stock");
        Console.WriteLine("===================================");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Product: {products[i]} - Price: {prices[i]} - Stock: {stock[i]}");
        }
    }
}