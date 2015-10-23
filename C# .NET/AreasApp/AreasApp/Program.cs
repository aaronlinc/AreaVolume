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
        }
    }

    public class Area
    {
        public float square(float height, float width)
        {
            return (height * width);
        }

        public double circle(double radius)
        {
            return ((Math.PI) * (radius * radius));
        }

    }
}
