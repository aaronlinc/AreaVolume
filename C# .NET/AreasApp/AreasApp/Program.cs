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

        public double elipse(double radius1, double radius2)
        {
            return ((Math.PI) * radius1 * radius2);
        }

        public double parallelogram(double height, double base1)
        {
            return (height * base1);
        }

        public double trapezoid(double height, double base1, double base2)
        {
            return (height/2)*(base1 + base2);
        }

        public double triangle(double base1, double height)
        {
            return (1 / 2) * base1 * height;
        }



    }
}
