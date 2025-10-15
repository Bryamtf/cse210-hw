using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Shape s = new Square("yelow", 20);
        Console.WriteLine(s.GetArea());
        Shape r = new Rectangle("green", 30, 60);
        Console.WriteLine(r.GetArea());
        Shape c = new Circle("red", 20);
        Console.WriteLine(c.GetArea());
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            
        }
    }
}