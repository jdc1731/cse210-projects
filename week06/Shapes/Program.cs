using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(5, "Red");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(4, 6, "Blue");
        shapes.Add(s2);

        Circle s3 = new Circle(3, "Green");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"Shape Color: {color}, Area: {area}");
        }

    }
}