using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dan_object
{
    internal class taxi
    {
        public string Name { get; set; }
        public bool OnDuty { get; set; }
        public float Id { get; set; }


        public void orderan()
        {
            Console.WriteLine("Driver Name: {0}", Name);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}\n", Id);
        }

        public void menjemput()
        {
            Console.WriteLine("rafi sedang menjemput penumpang", Name);
        }

        public void mengantar()
        {
            Console.WriteLine("rafi selesai mengantar penumpang", Name);
        }
    }
}

