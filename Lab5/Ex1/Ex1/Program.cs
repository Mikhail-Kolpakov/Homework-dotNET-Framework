// Варіант #9
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var transportArr = new[]
{
    new FloatingTransport("Перемога", 85000, "сталь", 100, 30),
    new FloatingTransport("Одеса", 21500, "деревина", 50, 15),
    new FloatingTransport("Перлина", 3.5F, "пластмаса", 5, 10),
    new FloatingTransport("Торпеда", 112000, "сталь", 150, 40),
    new FloatingTransport("Імпульс", 34000, "алюміній", 70, 20),
    new FloatingTransport("Вітязь", 13750, "деревина", 30, 10),
    new FloatingTransport("Фортеця Львів", 15000, "деревина", 40, 12),
    new FloatingTransport("Залізняк", 140200, "сталь", 200, 50),
    new FloatingTransport("Незламний", 65000, "сталь", 120, 35),
    new FloatingTransport("Кочівник", 6, "пластмаса", 10, 7),
    new FloatingTransport("Криворіг", 72000, "алюміній", 80, 25),
    new FloatingTransport("Спритняк", 2.7F, "деревина", 5, 25)
};

PrintTransports(transportArr, "Наявні плаваючі засоби: ");

var material = Input<string>("\nВведіть матеріал корпусу: ");
var speed = Input<float>("Введіть швидкість руху (км/год): ");
var suitableTransport = transportArr.Where(transport => transport.Material == material && transport.Speed >= speed).ToArray();

if (suitableTransport.Length is 0)
{
    Console.WriteLine("Плаваючих засобів з вказаними параметрами не знайдено.");
    return;
}

PrintTransports(suitableTransport, "\nЗнайдені плаваючі засоби: ");

return;

void PrintTransports(FloatingTransport[] arr, string info)
{
    Console.WriteLine(info);
    foreach (var transport in arr)
    {
        Console.WriteLine($"\nНазва: {transport.Name}");
        Console.WriteLine($"Водотоннажність: {transport.WaterContent} т");
        Console.WriteLine($"Матеріал корпусу: {transport.Material}");
        Console.WriteLine($"Кількість екіпажу: {transport.CrewCount}");
        Console.WriteLine($"Швидкість руху: {transport.Speed} км/год");
    }
}

T Input<T>(string prompt)
{
    T result;
    
    Console.Write(prompt);
    if (typeof(T) == typeof(string))
        result = (T)Convert.ChangeType(Console.ReadLine()!, typeof(T));
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

public record FloatingTransport(string Name, float WaterContent, string Material, int CrewCount, float Speed);