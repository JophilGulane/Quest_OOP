namespace _1_Quest_One
{
    // 1. Savings Calculator Refactor
    // You’re given a basic program to calculate a savings balance with monthly deposits and interest. Refactor it by creating classes and methods.

    // Given Code:
    /*
    double initialDeposit = 5000;
    double monthlyDeposit = 200;
    double interestRate = 0.04;
    int years = 10;

    double totalBalance = initialDeposit;
    for (int i = 0; i < years * 12; i++)
    {
        totalBalance += monthlyDeposit;
        totalBalance += totalBalance * (interestRate / 12);
    }
    Console.WriteLine($"Total balance after {years} years: {totalBalance:C}");
    */

    // Requirements:
    // - Create a SavingsAccount class with properties for the deposit amounts and interest rate.
    // - Implement methods in SavingsAccount for monthly and yearly calculations.
    // - Add a DisplayBalance method to print the balance at the end of each year.


    internal class Program
    {
        static void Main(string[] args)
        {
            double initialDeposit = 5000;
            double monthlyDeposit = 200;
            double interestRate = 0.04;
            int years = 10;
            SavingsAccount MySavingsAccount = new SavingsAccount(initialDeposit, monthlyDeposit, interestRate, years);

            MySavingsAccount.DisplayBalance();

        }
    }

    public class SavingsAccount
    {
        public double initialDeposit;
        public double monthlyDeposit;
        public double interestRate;
        public int years;


        public SavingsAccount(double initialDeposit, double monthlyDeposit, double interestRate, int years)
        {
            this.initialDeposit = initialDeposit;
            this.monthlyDeposit = monthlyDeposit;
            this.interestRate = interestRate;
            this.years = years;
        }

        public double monthlyCalculation()
        {

            initialDeposit += monthlyDeposit;
            initialDeposit += initialDeposit * (interestRate / 12);
            return initialDeposit;
        }

        public double yearlyCalculation()
        {
            double yearlyBalance = 0;
            for (int i = 0; i < 12; i++)
            {
                yearlyBalance = monthlyCalculation();
            }
            return yearlyBalance;
        }

        public void DisplayBalance()
        {
            for (int i = 0; i < years; i++)
            {
                Console.WriteLine($"{i + 1} \t {yearlyCalculation():C}");
            }

        }
    }
}
