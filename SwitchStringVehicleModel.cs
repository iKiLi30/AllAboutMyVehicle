using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutMyVehicle
{
    internal class SwitchStringVehicleModel
    {
        static void Main(string[] args)
        {
            string vehicleModel;
            string vehicleManufacture;

            Console.WriteLine();
            Console.WriteLine("What is the model of the vehicle?\n");
            vehicleModel= Console.ReadLine();
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
