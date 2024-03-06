// Варіант #9
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var motorcycles = new []
{
    new Motorcycle("Honda", 200, 2, 5000),
    new Motorcycle("Yamaha", 180, 2, 4500),
    new Motorcycle("Ducati", 250, 2, 8000)
};

for (int i = 0; i < motorcycles.Length - 1; i++)
{
    Console.WriteLine($"Порівняння мотоциклів {i + 1} і {i + 2}:");
    Console.WriteLine($"Чи вони рівні?: {motorcycles[i] == motorcycles[i + 1]}");
    Console.WriteLine($"Чи вони НЕ рівні?: {motorcycles[i] != motorcycles[i + 1]}");
    Console.WriteLine($"Чи мотоцикл {i + 1} дешевший за мотоцикл {i + 2}?: {motorcycles[i] < motorcycles[i + 1]}");
    Console.WriteLine($"Чи мотоцикл {i + 1} дорожчий за мотоцикл {i + 2}?: {motorcycles[i] > motorcycles[i + 1]}\n");
}

var combined = motorcycles[0] + motorcycles[1];
Console.WriteLine("Комбінування мотоциклів 1 та 2: ");
Console.WriteLine($"Марка: {combined.Brand}, Максимальна швидкість: {combined.MaxSpeed}, Кількість коліс: {combined.WheelCount}, Ціна: {combined.Price}");

internal class Motorcycle(string brand, int maxSpeed, int wheelCount, double price)
{
    private const float Epsilon = 1e-3F;
    public string Brand { get; set; } = brand;
    public int MaxSpeed { get; set; } = maxSpeed;
    public int WheelCount { get; set; } = wheelCount;
    public double Price { get; set; } = price;
    
    public static bool operator ==(Motorcycle m1, Motorcycle m2) =>
        m1.Brand == m2.Brand && m1.MaxSpeed == m2.MaxSpeed && 
            m1.WheelCount == m2.WheelCount && Math.Abs(m1.Price - m2.Price) < Epsilon;

    public static bool operator !=(Motorcycle m1, Motorcycle m2) =>
        !(m1 == m2);

    public static bool operator <(Motorcycle m1, Motorcycle m2) =>
        m1.Price < m2.Price;

    public static bool operator >(Motorcycle m1, Motorcycle m2) =>
        m1.Price > m2.Price;

    public static Motorcycle operator +(Motorcycle m1, Motorcycle m2) =>
        new (string.Join(" ", m1.Brand, m2.Brand), m1.MaxSpeed + m2.MaxSpeed,
            m1.WheelCount + m2.WheelCount, m1.Price + m2.Price);
}