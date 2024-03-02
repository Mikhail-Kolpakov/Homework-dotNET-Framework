using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var rectangle = new Rectangle(5, 4);
var circle = new Circle(3);

Console.WriteLine($"Периметр прямокутника: {rectangle.CalculatePerimeter()} см");
Console.WriteLine($"Площа прямокутника: {rectangle.CalculateArea()} см^2");
Console.WriteLine($"\nДовжина кола: {circle.CalculatePerimeter():f2} см");
Console.WriteLine($"Площа кола: {circle.CalculateArea():f2} см^2");

// Базовий абстрактиний клас Фігура
internal abstract class Shape
{
    public virtual float CalculatePerimeter() => 0;
    public virtual float CalculateArea() => 0;
}

// Похідний клас Прямокутник
internal class Rectangle(float length, float width) : Shape
{
    private float Length { get; } = length;
    private float Width { get; } = width;

    public override float CalculatePerimeter() =>
        2 * (Length + Width);
    
    public override float CalculateArea() =>
        Length * Width;
}

// Похідний клас Коло
internal class Circle(float radius) : Shape
{
    private float Radius { get; } = radius;

    public override float CalculatePerimeter() =>
        (float)(2 * Math.PI * Radius);
    
    public override float CalculateArea() =>
        (float)(Math.PI * Math.Pow(Radius, 2));
}