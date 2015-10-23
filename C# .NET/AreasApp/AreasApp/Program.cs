using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Area test = new Area();
            Console.WriteLine( test.square(2.0, 2.0));
            Console.WriteLine(test.circle(3.2));
            //Wait for user input to exit.
            Console.WriteLine("Press Enter to Exit...");
            Console.Read();
        }
    }

    public class Area
    {
        public double square(double height, double width)
        {
            return (height * width);
        }

        public double circle(double radius)
        {
            return ((Math.PI) * (radius * radius));
        }

    }
}
