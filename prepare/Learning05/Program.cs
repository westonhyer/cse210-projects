using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program started");
        
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square(25, "Blue");
        Circle c1 = new Circle(5, "Green");
        Rectangle r1 = new Rectangle(4, 6, "Red");

        shapes.Add(s1);
        shapes.Add(c1);
        shapes.Add(r1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}