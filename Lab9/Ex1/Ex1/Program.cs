using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var cargo = new CargoTransport(2000, 1000, 5000);
var passenger = new PassengerTransport(1500, 800, 50);

Console.WriteLine($"Прибуток вантажного транспорту: {cargo.CalculateProfit()}$");
Console.WriteLine($"Прибуток пасажирського транспорту: {passenger.CalculateProfit()}$");

// Базовий клас Транспорт
internal class Transport(float income, float expenses)
{
    private float Income { get; } = income; // Прибуток
    private float Expenses { get; } = expenses; // Витрати

    public virtual float CalculateProfit() =>
        Income - Expenses;
}

// Похідний клас Вантажний транспорт
internal class CargoTransport(float income, float expenses, float cargoWeight) : Transport(income, expenses)
{
    private float CargoWeight { get; } = cargoWeight; // Вага вантажу

    // Метод для розрахунку прибутку з урахуванням ваги вантажу
    public override float CalculateProfit() =>
        base.CalculateProfit() - CargoWeight * 0.1F;
}

// Похідний клас Пасажирський транспорт
internal class PassengerTransport(float income, float expenses, int numberOfPassengers) : Transport(income, expenses)
{
    private int NumberOfPassengers { get; } = numberOfPassengers; // Кількість пасажирів

    // Метод для розрахунку прибутку з урахуванням кількості пасажирів
    public override float CalculateProfit() =>
        base.CalculateProfit() + NumberOfPassengers * 5;
}