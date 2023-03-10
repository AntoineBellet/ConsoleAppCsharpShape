using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCsharpShape.Models
{
    public class Rectangle: Shape
    {
        public Rectangle(int v1, int v2)
        {
            Height = v1;
            Width = v2;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
