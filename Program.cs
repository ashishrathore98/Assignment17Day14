using System;

// Base class representing a shape
class Shape
{
    public string ShapeType { get; set; }

    public virtual double Area { get; }
    public virtual double Perimeter { get; }

    public Shape(string shapeType)
    {
        ShapeType = shapeType;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine("Shape Type: " + ShapeType);
        Console.WriteLine("Area: " + Area);
        Console.WriteLine("Perimeter: " + Perimeter);
    }
}

// Derived class representing a circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override double Area => Math.PI * Radius * Radius;

    public override double Perimeter => 2 * Math.PI * Radius;
}

// Derived class representing a rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height) : base("Rectangle")
    {
        Width = width;
        Height = height;
    }

    public override double Area => Width * Height;

    public override double Perimeter => 2 * (Width + Height);
}

// Derived class representing a triangle
class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC) : base("Triangle")
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double Area
    {
        get
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }

    public override double Perimeter => SideA + SideB + SideC;
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Triangle triangle = new Triangle(3, 4, 5);

        Console.WriteLine("Circle Info:");
        circle.PrintInfo();
        Console.WriteLine();

        Console.WriteLine("Rectangle Info:");
        rectangle.PrintInfo();
        Console.WriteLine();

        Console.WriteLine("Triangle Info:");
        triangle.PrintInfo();
    }
}