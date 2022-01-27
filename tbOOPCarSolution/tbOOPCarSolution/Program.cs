using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbOOPCarSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car("Volvo", "V90", "Röd", 2020, "Diesel", "ABC123");

            //Console.WriteLine(c1.brand);
            //Console.WriteLine(c2.brand);

            c1.Print();
            c2.Print();

            c1.Horn();
            c2.Horn();

            c2.Accelerate();
            c2.Accelerate();
            

            Console.WriteLine(c2.GetSpeed());
        }
    }
}
