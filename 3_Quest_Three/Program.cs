namespace _3_Quest_Three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Vehicle Rental System
            // The original code calculates rental costs without any object-oriented structure. Refactor it by introducing classes to represent different vehicle types and rental details.

            // Given Code:
            string vehicleType = "Sedan";
            double dailyRate = 30.0;
            int rentalDays = 5;
            double totalCost = dailyRate * rentalDays;
            Console.WriteLine($"Total cost to rent a {vehicleType} for {rentalDays} days: {totalCost:C}");

            // Requirements:
            // - Create a Vehicle class with properties for the type and daily rental rate.
            // - Add a RentalDetails class that contains the number of rental days.
            // - Implement a CalculateTotalCost method to calculate the total rental cost.
            // - Add a DisplayRentalSummary method to show the rental cost breakdown.


        }
    }
}
