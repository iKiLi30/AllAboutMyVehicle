namespace AllAboutMyVehicle
{
    internal class Program
    {

        void Iteratioin()
        {
            string? repairShopID;
            string? vehiclePolicyNumber;
            string? claimDate;
            double claimAmount;
            int numberOfClaimBeingMade;
            Console.WriteLine("How many claims are being made?\n");
            numberOfClaimBeingMade = Convert.ToInt32(Console.ReadLine());

            for (int claimCounter = 0; claimCounter < numberOfClaimBeingMade; claimCounter++)
            {
                Console.WriteLine("What is your repair shop id&\n");
                repairShopID = Console.ReadLine();
                Console.WriteLine("What is the vehicle policy number?\n");
                vehiclePolicyNumber = Console.ReadLine();
                Console.WriteLine("what is the amount being claimed" + " for the repiar?\n");
                claimAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What was the date of the repiar?\n");
                claimDate = Console.ReadLine();
                Console.WriteLine("the datails entered for repair " + (claimCounter + 1) + " are");
                Console.WriteLine("Repaire shop id:\t" + repairShopID);
                Console.WriteLine("Policy number:\t" + vehiclePolicyNumber);
                Console.WriteLine("Claim amount:\t" + claimAmount);
                Console.WriteLine("Claim date:\t" + claimDate);
            }

        }
        void Ternary()
        {
            int yearsOfNoClaims = Convert.ToInt32(Console.ReadLine());
            string message = yearsOfNoClaims > 10 ? "Years of no claims is more than 10" : "Years of no claim is less than or eq to 10";
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Ternary();

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
