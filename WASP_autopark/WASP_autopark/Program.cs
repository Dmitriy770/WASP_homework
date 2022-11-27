using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WASP_autopark;

namespace WASP_homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new PassengerCar("bmw", 240, 2010, 4));
            cars.Add(new PassengerCar("ford", 120, 2019, 7));
            cars.Add(new Truck("volvo", 500, 1990, "Petrov Alexey", 1000));
            cars.Add(new Truck("tesla", 900, 2100, "Petrov Ivan", 600));

            Autopark autopark = new Autopark("autopark", cars);
            Console.WriteLine(autopark);

        }
    }
}