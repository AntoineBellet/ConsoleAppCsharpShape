using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCsharpShape.Models
{
    public class Triangle: Shape
    {
        public Triangle(int v1, int v2)
        {
            Side = v1;
            Hight = v2;
        }

        public double Side { get; set; }
        public double Hight { get; set; }

        public override double Area()
        {
            return (Side * Hight) / 2;
        }
    }
}
