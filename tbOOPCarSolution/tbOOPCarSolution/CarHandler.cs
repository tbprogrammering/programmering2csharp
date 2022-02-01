using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbOOPCarSolution
{
    class CarHandler
    {
        private Dictionary<string, Car> carRegister;

        public CarHandler()
        {
            carRegister = new Dictionary<string, Car>();
        }

        public bool AddCar(string license_plate, string brand, string model, string colour, int year, string fuel, Engine engine)
        {
            if (!carRegister.ContainsKey(license_plate))
            {
                carRegister.Add(license_plate, new Car(brand, model, colour, year, fuel, license_plate, engine));
                return true;
            }

            return false;

        }
        public bool AddCar(string brand, string model, string colour, int year, string fuel, string license_plate,
            int hp, int num_cylinders, float cylinder_volume, string manufacturer)
        {
            if (!carRegister.ContainsKey(license_plate))
            {
                carRegister.Add(license_plate, new Car(brand, model, colour, year, fuel, license_plate, hp, num_cylinders, cylinder_volume, manufacturer));
                return true;
            }

            return false;
        }
        public bool RemoveCar(string license_plate)
        {

            return true;
        }
    }
}
