using System;
using System.Numerics;


namespace AllAboutMyVehicle
{
    public class Program
    {
        private static class VehicleShopID
        {
            static string[] repairShopClaims = new string[8];
            static string repairShopId;
            static string vehiclePolicyNumber;
            static double claimAmount;
            static DateTime claimDate;
            static int numberOfClaimsBeingMade;
            static int numberOfClaimsEntered = 0;
            static int arrayPositionCounter = 0;
            double totalOfAllClaims = 0.00;

            public static int HowManyClaimsAreBeingMade()
            {
                Console.WriteLine("HowManyClaimsAreBeingMade?");
                return numberOfClaimsBeingMade =  Convert.ToInt32(Console.ReadLine());
            }
            public static void CurrentValueOfCounter()
            {
                Console.WriteLine("The current value is the counter is " + numberOfClaimsEntered + "\n");
            }
            public static DateTime ReadRepairShopID()
            {
                Console.WriteLine("What is your repair shop ID?");
                return Convert.ToDateTime(Console.ReadLine());
            }
            public static void WriteRepairShopIdToArray()
            {
                repairShopClaims[arrayPositionCounter] = repairShopId;
                arrayPositionCounter++;
            }
            public static void ReadVehiclePolicyNumber()
            {
                Console.WriteLine("What is vehicle policy number?");
                vehiclePolicyNumber = Console.ReadLine();
            }
            public static void WriteVehiclePolicyNumberToArray()
            {
                repairShopClaims[arrayPositionCounter] = vehiclePolicyNumber;
                arrayPositionCounter++;
            }
            public static void ReadAmountBeingClaim()
            {
                Console.WriteLine("What is the amount being claimed for the repair?");
                claimAmount = Convert.ToDouble(Console.ReadLine());
            }
            public static void WriteClaimAmountToTheArray()
            {
                repairShopClaims[arrayPositionCounter] = claimAmount.ToString();
                arrayPositionCounter++;
            }
            public static void ReadRepairData()
            {
                Console.WriteLine("What was the data of the repai?");
                claimDate = Convert.ToDateTime(Console.ReadLine());
            }
            public static void WriteRepairDateToArray()
            {
                repairShopClaims[arrayPositionCounter] += claimDate.ToString(); 
                arrayPositionCounter++;
            }
            public static void DisplayAllItemsInArray()
                {
                    foreach (var itemInTheClaimArray in repairShopClaims)
                    {
                        Console.WriteLine("The item in array is " + itemInTheClaimArray);
                    }
                }
            public static double AccumulateClaimAmount(double claimAmountPassedIn, double totalOfAllClaims)
            {
                totalOfAllClaims += claimAmountPassedIn;
                return totalOfAllClaims;
            }
            public static void InfoFromVehicleShop()
            {
                do
                {
                    AccumulateClaimAmoun();
                    CurrentValueOfCounter();
                    ReadRepairShopID();
                    WriteRepairShopIdToArray();
                    ReadVehiclePolicyNumber();
                    ReadAmountBeingClaim();
                    WriteClaimAmountToTheArray();
                    WriteClaimAmountToTheArray();
                    ReadRepairData();
                    WriteRepairDateToArray();
                    HowManyClaimsAreBeingMade();
                }
                while (numberOfClaimsEntered < numberOfClaimsBeingMade);
            }
        }                   

        static void Main(string[] args)
        {
            Program program = new Program();

            Program.VehicleShopID.InfoFromVehicleShop();
            //program.Ternary();
            //program.Iteratioin();
            //program.Array();
            //program.FirstMethod();
            //program.YouVehicleModel();
        }

       
        void Array()
        {
            string[] repairShopClaims = new string[8];
            string? repairShopID;
            string? vehiclePolicyNumber;
            string? claimAmount;
            DateTime claimDate;
            int numberOfClaimsBeingMade;
            int numberOfClaimsEntered = 0;
            int arrayPositionCounter = 0;
            Console.WriteLine("How many cliams are being made?\n");
            numberOfClaimsBeingMade = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("The current value of the counter is: " + numberOfClaimsEntered);
                Console.WriteLine("What is your repair shop id\n");
                repairShopID = Console.ReadLine();

                repairShopClaims[arrayPositionCounter] = repairShopID;
                arrayPositionCounter++;

                Console.WriteLine("What is the vehicle policy number?");
                vehiclePolicyNumber = Console.ReadLine();

                repairShopClaims[arrayPositionCounter] = vehiclePolicyNumber;
                arrayPositionCounter++;

                Console.WriteLine("What is the amount being claimed for repair?");
                claimAmount = Console.ReadLine();

                Console.WriteLine("What is the date of the repaire? ");
                claimDate =  Convert.ToDateTime(Console.ReadLine());
                repairShopClaims[arrayPositionCounter] = claimDate.ToString();
                arrayPositionCounter++;
                numberOfClaimsEntered++;
            }while (numberOfClaimsEntered < numberOfClaimsBeingMade);
        }
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
        void FirstMethod()
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
            Console.WriteLine($"The average km/year is {vehicleCurrentMileges / vehicleAgeInYears}");
            Console.WriteLine($"The mileage factor is {quoterMilegeFactor}");
            Console.WriteLine($"The quotation is {quoterFinalAmountForPremium}");
            Console.WriteLine($"The discount is {quoterDiscount}");
            Console.WriteLine($"The final discount is {quoterFinalAmountForPremium}");
        }
        public void YouVehicleModel()
        {
            string vehicleModel;
            string vehicleManufacture;

            Console.WriteLine();
            Console.WriteLine("What is the model of the vehicle?\n");
            vehicleModel = Console.ReadLine();
            switch (vehicleModel)
            {
                case "Edge":
                case "Fiesta":
                case "Focus":
                case "Kega":
                case "Mondeo":
                case "Mustang":
                    vehicleManufacture = "Ford";
                    break;
                case "Astra":
                case "Corsa":
                case "Insignia":
                case "Viva":
                    vehicleManufacture = "Opel";
                    break;
                case "Altima":
                case "Juke":
                case "Sentra":
                    vehicleManufacture = "Nissan";
                    break;
                case "C-Class":
                case "E-Class":
                case "S-Class":
                case "GLA":
                case "GLC":
                case "GLE":
                    vehicleManufacture = "Mercedes-Benz";
                    break;
                default:
                    vehicleManufacture = "unknown";
                    break;
            }
        }
    }
}
