using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbAssociation
{
    class Building
    {
        List<Room> rooms = new List<Room>();
        List<Worker> workers = new List<Worker>();

        public Building(int sqm)
        {
            AddRoom(sqm);
        }

        public void AddRoom(int sqm)
        {
            rooms.Add(new Room(sqm));
        }

        public void HireWorker(Worker worker)
        {
            workers.Add(worker);
        }

        public void PrintAllCurrentWorkers()
        {
            foreach(Worker w in workers)
            {
                w.PrintWorkerData();
            }
        }

        class Room
        {
            int _sqm;

            public Room(int sqm)
            {
                _sqm = sqm;
            }

            public int GetSqm()
            {
                return _sqm;
            }
        }
    }
}
