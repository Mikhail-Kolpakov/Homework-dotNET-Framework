using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var car = new Car("Toyota", "Corolla", 2020);
car.DisplayInfo();

var bicycle = new Bicycle("Mountain Bike", 2019);
bicycle.DisplayInfo();

// Абстрактний клас Транспортний Засіб
internal abstract class TransportVehicle(int year)
{
    protected int Year { get; } = year;
    
    public abstract void DisplayInfo();
}

// Клас Автомобіль
internal class Car(string brand, string model, int year) : TransportVehicle(year)
{
    private string Brand { get; } = brand;
    private string Model { get; } = model;
    
    public override void DisplayInfo() =>
        Console.WriteLine($"Автомобіль: {Brand} {Model}, Рік: {Year}");
}

// Клас Велосипед
internal class Bicycle(string type, int year) : TransportVehicle(year)
{
    private string Type { get; } = type;
    
    public override void DisplayInfo() =>
        Console.WriteLine($"Вид велосипеду: {Type}, Рік: {Year}");
}