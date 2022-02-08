using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbSimpleInheritance
{
    class Program
    {
        class Fruit
        {
            protected int _weight; //Protected innebär att subklasser kan komma åt variablen.
            protected string _colour;
            private string not_inhetited_member; //Kommer inte att ärvas av subklasser då den är privat.

            public Fruit()
            {
                _weight = 0;
                _colour = "";
            }

            public Fruit(int weight, string colour)
            {
                _weight = weight;
                _colour = colour;
            }

            public int Weight //Property, med get och set 
            {  
                get { return _weight; }
                set { _weight = value; }
            }
            public string Colour //Property, med get och set
            {
                get { return _colour; }
                set { _colour = value; }
            }

            public virtual void EatMe() //Virtual innebär att en subklass kan ta över och bestämma ny funktionalitet
                                        //Det gör man genom att implementera funktionen med override i subklassen
            {
                Console.WriteLine("Svårt att veta vilken frukt det är, men en frukt är det i alla fall");
            }

            public virtual void PrintInfo()
            {
                Console.WriteLine("Vikt {0} Färg {1}", _weight, _colour);
            }

            public void Throw() //Inte override, dvs subklasser får den här funktionen utan att kunna ändra beteende
            {
                Console.WriteLine("SPLASH!!");
            }
        }

        class Apple : Fruit //Här kan vi se att klassen Apple ärver av klassen Fruit. Fruit är då basklass till subklassen Apple.
            //Allt som Fruit har kommer också Apple att få.
        {
            float _radius; //Ny medlemsvariabel för Apple
            public Apple() : base() //Här anropas basklassens default-konstruktor -> : base()
            {
                _radius = 0;
            }
            public Apple(int weight, string colour, float radius) : base(weight, colour) //Här anropas basklassens konstruktor, skickar vidare vikt och färg -> : base(weight, colour)
            {
                _radius = radius;
            }

            public override void EatMe() //Här ändras beteendet eftersom subklassen använder override
                                         //Den här metoden kommer istället att användas för den här klassen
            {
                Console.WriteLine("Smakar som ett gott äpple");
            }
            public override void PrintInfo()
            {
                base.PrintInfo(); //base. -> anropar basklassen metod
                Console.WriteLine("Radie {0}", _radius);
            }
        }

        class Banana : Fruit
        {
            float _length;
            bool _peeled;
            public Banana() : base()
            {
                _length = 0;
                _peeled = false;
            }
            public Banana(int weight, string colour, float length) : base(weight, colour)
            {
                _length = length;
                _peeled = false;
            }

            public override void EatMe()
            {
                if (_peeled)
                    Console.WriteLine("Detta är en fin fin banan");
                else
                    Console.WriteLine("Nope, äter inte med skalet på");
            }
            public override void PrintInfo()
            {
                //Här anropar vi inte basklassens metod, utan skriver ut allting här i klassen
                Console.WriteLine("Vikt {0} Färg {1} Längd {2}", _weight, _colour, _length);
            }

            public void Peel() //Den här metoden finns enbart i banan.
            {
                Console.WriteLine("Skala banan...");
                _peeled = true;
            }
        }

        static void Main(string[] args)
        {
            Fruit fr = new Fruit(); //Enbart en Fruit
            Apple ap = new Apple(); //Ett objekt som också är en frukt
            Banana ba = new Banana(); //Ett objekt som också är en frukt


            List<Fruit> frukter = new List<Fruit>(); //En lista som kan hålla frukter
            frukter.Add(new Fruit(100, "Vit")); //Lägg till en frukt
            frukter.Add(new Banana(230, "Gul", 17)); //Lägg till en banan (som också är en frukt)
            frukter.Add(new Apple(322, "Röd", 5)); //Lägg till ett äpple (som också är en frukt)


            //Gå igenom alla frukter i listan
            foreach(Fruit f in frukter)
            {
                f.PrintInfo(); //Eftersom alla frukter har print-info kan vi nu anropa detta
                f.EatMe();
                if (f.GetType() == typeof(Banana)) //Kolla om objektet är en banan
                {
                    ((Banana)f).Peel(); //Typkonvertera en frukt till en banana, OBS kan man klart enbart göra om det är en banan
                    f.EatMe();
                }
                f.Throw();
                Console.WriteLine("\n");
            }

            frukter.Add(new Banana(100, "GulBrun", 12)); //Lägg till en banan till i listan

            //Med hjälp av LINQ kan vi hämta alla objekt av en viss typ från listan
            //Syntax: listNamn.OfType<Klasstyp>()
            foreach (Banana b in frukter.OfType<Banana>())
            {
                b.Peel(); //Behöver inte typkonvertera då alla objekt som itereras är av typen banan
                b.Throw();
            }
        }
    }
}
