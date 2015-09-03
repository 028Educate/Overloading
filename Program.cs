using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading of the Swim method
            Swim();
            Swim(30);
            Swim(50, "At you");
        }

        //Overloading of the Swim method as all three methods have the same name but differ as each have a different parameter list i.e no, 1 or 2 parameters
        //And depending on what parameters are passed if any to the method, then the correct one is executed at run time
        private static void Swim()
        {
            Console.WriteLine("Swimming at a leisurely pace");
        }

        private static void Swim(int speed)
        {
            Console.WriteLine("Swimming at " + speed + "mph");
        }

        private static void Swim(int speed, string direction)
        {
            Console.WriteLine("Swimming towards " + direction + " at " + speed + "mph");
        }


    }
}
