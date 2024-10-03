using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UML_to_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle("Bobby", 2.4);
            Vehicle secondVehicle = new Vehicle("Billy", 3.2);
            Vehicle thirdVehicle = new Vehicle("Susan", 2.0);

            CarFerry terryFerry = new CarFerry("Terry the ferry", 40);

            terryFerry.addVehicle(firstVehicle);
            terryFerry.addVehicle(secondVehicle);
            terryFerry.addVehicle(thirdVehicle);

            Console.WriteLine("After adding the vehicles " + firstVehicle.getLicensePlate() + ", " + secondVehicle.getLicensePlate() + " and " + thirdVehicle.getLicensePlate() + ".\n" +
                              "The total amount of vehicles onboard is now " + terryFerry.amountOfVehiclesOnBoard() + ".\n" +
                              "The total weight on " + terryFerry.getName() + " is " + terryFerry.getTotalWeight() + " ton(s).\n" +
                              "The total carry capacity is " + terryFerry.getMaxWeight() + " ton(s).");


            for (int i = 0; i < terryFerry.amountOfVehiclesOnBoard(); i++)
            {
                Console.WriteLine("Car #" + (i + 1) + " is " + terryFerry.getVehicleList(i) + " at " + terryFerry.getWeightList(i) + " ton(s).");
            }


        }
    }
}