using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var fighterJet = new FighterJet();
fighterJet.InputData();
fighterJet.DisplayData();

Console.WriteLine();

var passengerLiner = new PassengerLiner();
passengerLiner.InputData();
passengerLiner.DisplayData();

internal abstract class Aircraft
{
    protected string? Model { get; set; }
    protected int Year { get; set; }

    protected T Input<T>(string prompt)
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
        else
            throw new NotSupportedException("Тип даних не підтримується.");

        return result;
    }
    
    public abstract void InputData();
    public abstract void DisplayData();
}

internal class FighterJet : Aircraft
{
    private int MaxSpeed { get; set; }

    public override void InputData()
    {
        Console.WriteLine("Введіть характеристики винищувача: ");
        Model = Input<string>("Модель: ");
        Year = Input<int>("Рік: ");
        MaxSpeed = Input<int>("Максимальна швидкість (км/год): ");
    }

    public override void DisplayData() =>
        Console.WriteLine($"Винищувач - Модель: {Model}, Рік: {Year}, Максимальна швидкість: {MaxSpeed} км/год");
}

internal class PassengerLiner : Aircraft
{
    private int PassengerCapacity { get; set; }

    public override void InputData()
    {
        Console.WriteLine("Введіть характеристики пасажирського лайнера: ");
        Model = Input<string>("Модель: ");
        Year = Input<int>("Рік: ");
        PassengerCapacity = Input<int>("Пасажировмісткість: ");
    }

    public override void DisplayData() =>
        Console.WriteLine($"Пасажирський лайнер - Модель: {Model}, Рік: {Year}, Пасажировмісткість: {PassengerCapacity}");
}