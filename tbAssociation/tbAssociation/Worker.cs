using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbAssociation
{
    class Worker
    {
        string _name;
        string _title;

        public Worker()
        {
            _name = "undefined";
            _title = "undefined";
        }
        public Worker(string name, string title)
        {
            _name = name;
            _title = title;
        }

        public void PrintWorkerData()
        {
            Console.WriteLine(_name + " " + _title);
        }


    }
}
