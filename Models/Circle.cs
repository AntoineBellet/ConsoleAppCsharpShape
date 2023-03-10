using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCsharpShape.Models
{
    public class Circle: Shape
    {
        public Circle(int v)
        {
            Radius = v;
        }

        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
