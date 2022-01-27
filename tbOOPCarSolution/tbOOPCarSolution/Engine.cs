using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbOOPCarSolution
{
    class Engine
    {
        int hp;
        int num_cylinders;
        float cylinder_volume;
        string manufacturer;

        public Engine()
        {
            this.hp = 0;
            this.num_cylinders = 0;
            this.cylinder_volume = 0;
            this.manufacturer = "undefined";
        }

        public Engine(int hp, int num_cylinders, float cylinder_volume, string manufacturer)
        {
            this.hp = hp;
            this.num_cylinders = num_cylinders;
            this.cylinder_volume = cylinder_volume;
            this.manufacturer = manufacturer;
        }

    }
}
