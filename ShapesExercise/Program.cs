using System.Runtime.CompilerServices;
using ShapesExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Circle c1 = new Circle("Circle", "Red", 5);
        Circle c2 = new Circle("Circle2", "Blue", 10);

        //Console.WriteLine(c1.GetInfo());
        //Console.WriteLine(c2.GetColor());

        Rectangle r1 = new Rectangle("Rectangle", "Yellow", 5, 10);
        Rectangle r2 = new Rectangle("Rectangle2", "Green", 10, 15);

        //Console.WriteLine(r1.GetInfo());
        //Console.WriteLine(r2.GetColor());

        Triangle t1 = new Triangle("Triangle", "Orange", 5, 10);
        Triangle t2 = new Triangle("Triangle", "Pink", 10, 15);
        Console.WriteLine("GetInfo ja GetColor toimii");
        Console.WriteLine(t1.GetInfo());
        Console.WriteLine(t2.GetColor());

        List<Shape> Shapes = new List<Shape>();
        Shapes.Add(c1); Shapes.Add(c2);
        Shapes.Add(r1); Shapes.Add(r2);
        Shapes.Add(t1); Shapes.Add(t2);

        Console.WriteLine("\nKäy kaikki listan muodot läpi");
        foreach(Shape shape in Shapes)
        {
            Console.WriteLine(shape.GetInfo());
        }

        Console.WriteLine("\nKäy listan läpi ja tulostaa vain ympyrät");
        foreach (Shape shape in Shapes)
        {
            if (shape is Circle)
            {
                Console.WriteLine(shape.GetInfo());
            }
        }

        Console.WriteLine("\nLajittelee listan pinta-alan mukaan");
        Shapes.Sort();

        foreach (Shape shape in Shapes)
        {
            Console.WriteLine(shape.GetInfo());
        }

    }
}