using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbWPFPrototype
{
    class Car /*: IComparer*/
    {
        string _license_plate;
        string _brand;
        string _model;
        int _year;
        string _colour;
        string _fuel;
        DateTime? _reg_date;
                 
        public string License_Plate { get => _license_plate; }
        public string Brand { get => _brand; }
        public string Model { get => _model; }
        public int Year { get => _year; }
        public string Colour { get => _colour; }
        public string Fuel { get => _fuel; }
        public DateTime? RegDate { get => _reg_date; }

        public Car(string license_plate, string brand, string model, int year, string colour, string fuel, DateTime?  reg_date)
        {
            _license_plate = license_plate;
            _brand = brand;
            _model = model;
            _year = year;
            _colour = colour;
            _fuel = fuel;
            _reg_date = reg_date;
        }

        /*public int Compare(object x, object y)
        {
            Car c1 = (Car)x;
            Car c2 = (Car)y;

            return c1.License_Plate.CompareTo(c2.License_Plate);
        }*/

    }
} 
