using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var hoursWorked = Input<int>("Введіть кількість відпрацьованих годин: ");
var hourlyRate = Input<float>("Введіть ставку за годину: ");

Console.WriteLine($"Загальна оплата праці: {hoursWorked * hourlyRate:f2} грн");

return;

T Input<T>(string prompt)
{
    T result = default!;
    
    Console.Write(prompt);
    if (typeof(T) == typeof(int))
        while (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));
            result = (T)(object)number;
        }
    else if (typeof(T) == typeof(float))
        while (!float.TryParse(Console.ReadLine(), out float number))
        {
            Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));
            result = (T)(object)number;
        }
    else
        throw new NotSupportedException("Тип даних не підтримується.");

    return result;
}