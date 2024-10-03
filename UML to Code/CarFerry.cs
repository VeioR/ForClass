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
        private List<string> vehiclesOnboard = new List<string>();
        private List<double> weightOnboard = new List<double>();
        private double totalWeight;

        public CarFerry(string name, double maxWeight)
        {
            this.name = name;
            this.maxWeight = maxWeight;
        }
        public void addVehicle(Vehicle vehicle)
        {
            vehiclesOnboard.Add(vehicle.getLicensePlate());
            weightOnboard.Add(vehicle.getWeight());
        }

        public void removeVehicle(Vehicle vehicle)
        {
            vehiclesOnboard.Remove(vehicle.getLicensePlate());
            weightOnboard.Remove(vehicle.getWeight());
        }
        public string getVehicleList(int x)
        {
            return vehiclesOnboard[x];
        }

        public double getWeightList(int x)
        {
            return weightOnboard[x];
        }

        public int amountOfVehiclesOnBoard()
        {
            return vehiclesOnboard.Count;
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
            foreach (double i in weightOnboard)
            {
                totalWeight += i;
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
S