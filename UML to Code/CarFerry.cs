using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_to_code
{
    internal class CarFerry
    {
        private string name;
        private double maxWeight;
        private List<Vehicle> vehicles = new List<Vehicle>();
        private double totalWeight;

        public CarFerry(string name, double maxWeight)
        {
            this.name = name;
            this.maxWeight = maxWeight;
        }
        public void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void removeVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }
        public string getVehicleList(int x)
        {
            return vehicles[x].getLicensePlate();
        }

        public double getWeightList(int x)
        {
            return vehicles[x].getWeight();
        }

        public int amountOfVehiclesOnBoard()
        {
            return vehicles.Count;
        }

        public string getName()
        {
            return name;
        }

        public double getMaxWeight()
        {
            return maxWeight;
        }

        public double getTotalWeight()
        {
            foreach (Vehicle i in vehicles)
            {
                totalWeight += i.getWeight();
            }
            return totalWeight;
        }

        public bool isOverWeight()
        {

            if (this.getTotalWeight() <= maxWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}