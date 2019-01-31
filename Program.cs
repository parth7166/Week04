using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            countryside Ontario = new countryside();
            Ontario.run();
        }
    }
    class Village
    {
        public static int numberofvillages = 0;
        public Village nextvillage;
        public Village previousvillage;
        public string vilagename;
        public bool isastrildehere = false;

        public Village() { Village.numberofvillages++; }


    }
    class countryside
    {
        public Village maple;
        public Village toronto;
        public Village ajax;
        public Village head;
        public Village tail;
        public Village temp;

        public void run()
        {
            this.AppDomainInitializer();
            this.lookforasterdle();
        }

        public void AppDomainInitializer()
        {
            maple = new Village();
            maple.vilagename = "MAPLE";
            maple.previousvillage = null;
            maple.nextvillage = toronto;
            maple.isastrildehere = true;
            toronto = new Village();
            toronto.vilagename = "TORONTO";
            toronto.previousvillage = maple;
            toronto.nextvillage = ajax;
            ajax = new Village();
            ajax.vilagename = "AJAX";
            ajax.previousvillage = toronto;
            ajax.nextvillage = null;


        }

        public void lookforasterdle()
        {
            head = maple;

            if(head.isastrildehere)
            {
                Console.WriteLine("ASTRILDE IS IN " + head.vilagename);
            }
            while (true)
            {

            }
        }

    }
}
