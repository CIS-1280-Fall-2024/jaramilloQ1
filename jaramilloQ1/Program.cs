using System;
using static jaramilloQ1.GravitationalForceClass;
namespace jaramilloQ1
{
    public class Program
    {
        public static void Main()
        {
            GravitationalForce gf = new GravitationalForce
            {
                Object1Name = "Earth",
                Object2Name = "Moon",
                Mass1 = 5.972e24, // Mass of Earth in kg
                Mass2 = 7.348e22, // Mass of Moon in kg
                Radius = 3.844e8  // Distance between Earth and Moon in meters
            };

            Console.WriteLine(gf);
        }
    }
}