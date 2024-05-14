using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial investment:");
            int initialInvestment = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter yearly interest percentage:");
            double interestPercentageYearly = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter time period in years:");
            int timePeriodInYears = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter compounding frequency in years:");
            int compoundingFrequencyInYears = Convert.ToInt32(Console.ReadLine());

            decimal compoundAmount = initialInvestment * (decimal)Math.Pow((1 + (interestPercentageYearly / 100) / compoundingFrequencyInYears), (compoundingFrequencyInYears * timePeriodInYears));

            decimal compoundInterest = compoundAmount - initialInvestment;

            Console.WriteLine("Compounded amount: " + compoundAmount);
            Console.WriteLine("Compounded interest: " + compoundInterest);
        }
    }
}
