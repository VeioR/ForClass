using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_to_code
{
    internal class Vehicle
    {
        private string licensePlate;
        private double weight;

        public Vehicle(string licensePlate, double weight)
        {
            this.licensePlate = licensePlate;
            this.weight = weight;
        }

        public string getLicensePlate()
        {
            return licensePlate;
        }

        public double getWeight()
        {
            return weight;
        }

        /*
        public string toString()
        {

        }

        public bool equals(Vehicle other)
        {

        }
        */
    }
}