using System;
using System.Runtime.ConstrainedExecution;
using ConsoleAppCsharpShape.Models;
using ConsoleAppCsharpShape.Services;

namespace ConsoleAppCsharpShape;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(5, 2);
        Rectangle rectangle = new Rectangle(2, 2);
        Circle circle = new Circle(2);
        Square square = new Square(2);


        Shape[] Forms = new Shape[]
        {
            triangle,
            rectangle,
            circle,
            square
        };
        var a = new AreaCalculatorService();

        Console.WriteLine(a.TotalAreaForms(Forms));
    }
}


