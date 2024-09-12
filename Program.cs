namespace AllAboutMyVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vehicleAgeInYears;
            int vehicleCurrentMileges;
            double quoterAveregeExpectedKilomiter = 10000;
            double quoterBaseRate = 100.00;
            double quoterBaseAge = 10;
            double quoterAgeFactor;
            double quoterAgeFactorPremium;
            double quoterMilegeFactor;
            double quoterMilegeFactorPremium;
            double quoterDiscount;
            double quoterAmountForPremium;
            double quoterFinalAmountForPremium;

            Console.WriteLine("Car Quotation Application");
            Console.WriteLine();
            Console.WriteLine("What is the age, in full years, of " + "of the vehicle?\n");

            vehicleAgeInYears = Convert.ToInt32(Console.ReadLine());
            quoterAgeFactor = (double)(quoterBaseAge) / (double)(vehicleAgeInYears);
            quoterAgeFactorPremium = quoterBaseRate * quoterAgeFactor;

            Console.WriteLine("What is the current mileges of " + "of the vehicle ?\n");
            vehicleCurrentMileges = Convert.ToInt32(Console.ReadLine());

            quoterMilegeFactor = (double)vehicleCurrentMileges / (double)vehicleAgeInYears / quoterAveregeExpectedKilomiter;
            quoterMilegeFactorPremium = quoterBaseRate / quoterMilegeFactor;
            quoterAmountForPremium = quoterAgeFactorPremium + quoterMilegeFactorPremium;
            quoterDiscount = (1 / (double)vehicleAgeInYears) * quoterAmountForPremium;
            quoterFinalAmountForPremium = quoterAmountForPremium - quoterDiscount;

            Console.WriteLine("Quotation is for 1 year from today\n");
            Console.WriteLine($"The age of vehicle is {vehicleAgeInYears}");
            Console.WriteLine($"The age of factor is  {quoterAgeFactor}");
            Console.WriteLine($"The average km/year is {vehicleCurrentMileges/vehicleAgeInYears}");
            Console.WriteLine($"The mileage factor is {quoterMilegeFactor}");
            Console.WriteLine($"The quotation is {quoterFinalAmountForPremium}");
            Console.WriteLine($"The discount is {quoterDiscount}");
            Console.WriteLine($"The final discount is {quoterFinalAmountForPremium}");


        }
    }
}
