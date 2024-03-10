using System;

class Program
{
    static void Main(string[] args)
    {
        ShapeRegistry registry = new ShapeRegistry();

        
        registry.AddShape("circle1", new Circle(5.0));
        registry.AddShape("square1", new Square(4.0));

      
        IShape circle = registry.GetShape("circle1");
        if (circle != null)
        {
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
        }

        IShape square = registry.GetShape("square1");
        if (square != null)
        {
            Console.WriteLine($"Area of Square: {square.CalculateArea()}");
        }

        
        registry.RemoveShape("circle1");

        
        IShape circleRemoved = registry.GetShape("circle1");
        if (circleRemoved == null)
        {
            Console.WriteLine("Circle1 is not registered.");
        }
    }
}
