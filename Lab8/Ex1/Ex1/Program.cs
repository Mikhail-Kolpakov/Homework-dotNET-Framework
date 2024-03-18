// Варіант #28
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var count = Input<int>("Введіть кількість мотоциклів: ");
var motorcycles = new Motorcycle[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"\nЗаповніть характеристики мотоциклу {i + 1}: ");
    var brand = Input<string>("Марка: ");
    var enginePower = Input<int>("Потужність двигуна (к. с.): ");
    var fuelType = Input<string>("Тип палива: ");
    var maxSpeed = Input<int>("Максимальна швидкість (км/год): ");
    var price = Input<float>("Ціна ($): ");

    motorcycles[i] = new Motorcycle(brand, enginePower, fuelType, maxSpeed, price);
}

Console.WriteLine("\nВведіть критерії вибірки: ");
var minEnginePower = Input<int>("Мінімальна потужність двигуна (к. с.): ");
var minMaxSpeed = Input<float>("Мінімальна швидкість (км/год): ");
var maxPrice = Input<float>("Максимальна ціна ($): ");
var suitableTransport = motorcycles.Where(m => m.EnginePower >= minEnginePower && m.MaxSpeed >= minMaxSpeed && m.Price <= maxPrice).ToArray();

if (suitableTransport.Length is 0)
{
    Console.WriteLine("Плаваючих засобів з вказаними параметрами не знайдено");
    return;
}

PrintTransports(suitableTransport, "\nМотоцикли, що задовольняють критерії вибірки: ");

return;

void PrintTransports(IEnumerable<Motorcycle> arr, string info)
{
    Console.WriteLine(info);
    foreach (var transport in arr)
    {
        Console.WriteLine($"\nМарка: {transport.Brand}");
        Console.WriteLine($"Потужність двигуна: {transport.EnginePower} к. с.");
        Console.WriteLine($"Вид палива: {transport.FuelType}");
        Console.WriteLine($"Максимальна швидкість: {transport.MaxSpeed} км/год");
        Console.WriteLine($"Ціна: {transport.Price} $");
    }
}

static T Input<T>(string prompt)
{
    T result;
    
    Console.Write(prompt);
    if (typeof(T) == typeof(string))
        result = (T)Convert.ChangeType(Console.ReadLine()!, typeof(T));
    else if (typeof(T) == typeof(int))
    {
        int number;
        
        while (!int.TryParse(Console.ReadLine(), out number))
            Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));
        
        result = (T)Convert.ChangeType(number, typeof(T));
    }
    else if (typeof(T) == typeof(float))
    {
        float number;
        
        while (!float.TryParse(Console.ReadLine(), out number))
            Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));
        
        result = (T)Convert.ChangeType(number, typeof(T));
    }
    else
        throw new NotSupportedException("Тип даних не підтримується.");

    return result;
}

internal record Motorcycle(string Brand, int EnginePower, string FuelType, float MaxSpeed, float Price);