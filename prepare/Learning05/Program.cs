using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq1 = new Square("green", 4);
        Rectangle rect1 = new Rectangle("blue", 2, 3);
        Circle circ1 = new Circle("red", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq1);
        shapes.Add(rect1);
        shapes.Add(circ1);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}