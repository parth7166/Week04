using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside Ontario = new Countryside();
            Ontario.run();

        }
    }

    class LearningExample
    {
        public void run()
        {
            Village Toronto;
            Village a;
            Village b;
            Toronto = new Village();
            a = Toronto;

            Toronto = new Village();
            b = Toronto;

            if (a == b) { Console.WriteLine("same"); }
            else
            { Console.WriteLine("different obj refs"); }
        }
    }
    class Village
    {
        public static int numberOfVillages = 0;
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;

        public Village()
        {
            Village.numberOfVillages++;
        }
    }

    class Countryside
    {
        public Village Maple;
        public Village Toronto;
        public Village Ajax;
        public Village Head;
        public Village Tail;
        public Village Current;

        public void run()
        {
            this.MapInitializer();
            this.LookForAstrilde();
            Console.WriteLine("Hugi found Astrilde in " + Current.VillageName);
        }

        public void MapInitializer()
        {
            Ajax = new Village();
            Toronto = new Village();
            Maple = new Village();

            Maple.VillageName = "Maple";
            Maple.previousVillage = null;
            Maple.nextVillage = Toronto;
            Maple.isAstrildeHere = true;

            Toronto.previousVillage = Maple;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;

            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;

        }
        public void LookForAstrilde()
        {

            Current = Maple;
            while (Current.nextVillage != null)
            { if (Current.isAstrildeHere)
                { Console.WriteLine("Found Astrilde");
                    return;

                }
                else
                {
                    Current = Current.nextVillage;

                }
            }
        }

    }
}
