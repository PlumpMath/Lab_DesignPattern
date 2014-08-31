using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatToMake = "van"; // or "van"
            AbstractVehicleFactory factory = null;

            // Create the correct 'factory'...
            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            // Create the vehicle parts, either a car or a van...
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            // See what we've created...
            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts);

            Console.Read();
        }
    }
}
