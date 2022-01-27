using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbOOPCarSolution
{
    class Car
    {
        public string brand;
        public string model;
        public int year;
        public string fuel;
        public string license_plate;
        private float speed;
        public string colour;

        Engine engine;

        public Car()
        {
            brand = "undefined";
            model = "undefined";
            year = 0;
            fuel = "undefined";
            license_plate = "undefined";
            speed = 0f;
            colour = "undefined";
            engine = new Engine();
        }

        public Car(string brand, string model, string colour,
            int year, string fuel, string license_plate, Engine engine)
        {
            this.brand = brand;
            this.model = model;
            this.colour = colour;
            this.year = year;
            this.fuel = fuel;
            this.license_plate = license_plate;
            this.speed = 0;
            this.engine = engine;
        }

        public Car(string brand, string model, string colour,
            int year, string fuel, string license_plate,
            int hp, int num_cylinders, float cylinder_volume, string manufacturer)
        {
            this.brand = brand;
            this.model = model;
            this.colour = colour;
            this.year = year;
            this.fuel = fuel;
            this.license_plate = license_plate;
            this.speed = 0;
            this.engine = new Engine(hp, num_cylinders, cylinder_volume, manufacturer);
        }

        public void Print()
        {
            Console.WriteLine($"{license_plate} {brand} {model} {colour} {year} {fuel} {speed}");
        }

        public void Horn()
        {
            Console.WriteLine($"{license_plate} Tut tut");
        }

        public float Accelerate()
        {
            speed += 10f;
            return speed;
        }

        public float Brake()
        {
            speed -= 10f;
            return speed;
        }

        public float GetSpeed()
        {
            return speed;
        }


    }
}
