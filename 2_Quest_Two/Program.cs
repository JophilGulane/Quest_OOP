namespace _2_Quest_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Employee Payroll System
            // An initial program calculates a basic payroll for employees, but it lacks any structure. Refactor it to improve readability and reusability.

            // Given Code:
            string employeeName = "Alice";
            double hourlyRate = 15.0;
            int hoursWorked = 160;

            double monthlySalary = hourlyRate * hoursWorked;
            Console.WriteLine($"{employeeName} earned {monthlySalary:C} this month.");

            // Requirements:
            // - Create an Employee class with properties for name, hourly rate, and hours worked.
            // - Add a CalculateMonthlySalary method to calculate and return the salary.
            // - Create a DisplayEmployeePayroll method to show the employee’s monthly salary in a formatted way.


        }
    }
}
