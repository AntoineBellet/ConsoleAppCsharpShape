using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCsharpShape.Models
{
    public class Square: Shape
    {
        public Square(int v1)
        {
            Side = v1;
        }

        public double Side { get; set; }

        public override double Area()
        {
            return (Side * Side) ;
        }
    }
}
