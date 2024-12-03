using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaramilloQ1
{
    internal class GravitationalForceClass
    {
public class GravitationalForce
    {
        // Constant for the gravitational constant G
        private const double G = 6.67408e-11;

        // Properties for the names of the objects
        public string Object1Name { get; set; }
        public string Object2Name { get; set; }

        // Properties for the masses of the objects
        public double Mass1 { get; set; }
        public double Mass2 { get; set; }

        // Property for the distance between the objects
        public double Radius { get; set; }

        // Read-only property for the gravitational force
        public double Force
        {
            get
            {
                return CalculateForce(); //Calculate should be called from the sets. RJG
            }
        }

        // Method to calculate the gravitational force
        private double CalculateForce()
        {
            return G * (Mass1 * Mass2) / (Radius * Radius);
        }

        // Override ToString() method to return a formatted string
        public override string ToString()
        {
            return $"The force between {Object1Name} and {Object2Name} is {Force:e2} N.";
        }
    }
}
}
