namespace _5_Quest_Five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Online Order Management
            // The code calculates a total order cost but lacks structure. Refactor it into classes for better organization.

            // Given Code:
            double itemPrice = 50.0;
            int quantity = 3;
            double taxRate = 0.05;
            double totalCost = (itemPrice * quantity) * (1 + taxRate);
            Console.WriteLine($"Total order cost: {totalCost:C}");

            // Requirements:
            // - Create a Product class with properties for the price and quantity.
            // - Implement an Order class with a CalculateTotalCost method that includes tax.
            // - Add a DisplayOrderSummary method to print out the order details in a formatted way.

        }
    }
}
