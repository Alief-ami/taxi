using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dan_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            taxi Taxi = new taxi();
            Taxi.Name = "budi";
            Taxi.OnDuty = true;
            Taxi.Id = 10;

            Taxi.orderan();
            Taxi.menjemput();
            Taxi.mengantar();

            Console.ReadKey();
        }
    }
}