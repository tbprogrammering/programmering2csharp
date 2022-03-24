using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> companyABC = new List<Worker>();
            companyABC.Add(new Worker("Jonas", "Grävare"));
            companyABC.Add(new Worker("Lisa", "Chef"));

            Building myBuilding;

            {
                myBuilding = new Building(100);
                myBuilding.AddRoom(50);

                myBuilding.HireWorker(companyABC[0]);

                Console.WriteLine("I BYGGNAD FINNS FÖLJANDE ARBETARE:");
                myBuilding.PrintAllCurrentWorkers();
                myBuilding = null;
            }

            Console.WriteLine("I FÖRTAGET FINNS FÖLJANDE ARBETARE");
            foreach(Worker w in companyABC)
            {
                w.PrintWorkerData();
            }




            //Room r = new Room(200); GÅR EJ EFTERSOM Room-klassen är defienerad i klassen Building
        }
    }
}
