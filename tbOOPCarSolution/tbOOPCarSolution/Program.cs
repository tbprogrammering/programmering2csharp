using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbOOPCarSolution
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine($"\nMENYVAL:\n1. Lägg till bil\n");
        }

        static int GetUserInput()
        {
            int choice = 0;
            //try / catch för att hantera om användaren matar in någoit som inte kan konverteras till en int
            try { choice = int.Parse(Console.ReadLine()); }
            catch { choice = -1; }

            return choice;
        }

        static void Main(string[] args)
        {
            Car c = new Car();

            Engine e2 = new Engine(200, 6, 2.0f, "Volvo");
            Car c2 = new Car("Volvo", "V90", "White", 2019, "Diesel", "ABC123", e2);


            CarHandler carRegister = new CarHandler();

            while (true)
            {
                ShowMenu();
                int choice = GetUserInput();
                
                //Mata in val
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Skriv in bildata:");
                        //Låt användaren mata un data och lagra i variabler som sedan skickas med i AddCar(...)
                        //carRegister.AddCar(...);
                        break;

                    default:
                        Console.WriteLine("Fel inmatning\n");
                        break;
                }
            }
        }
    }
}
