using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var hoursWorked = Input<int>("Введіть кількість відпрацьованих годин: ");
var hourlyRate = Input<float>("Введіть ставку за годину: ");

Console.WriteLine($"\nЗагальна оплата праці: {hoursWorked * hourlyRate:f2} грн");

return;

T Input<T>(string prompt)
{
    T result;
    
    Console.Write(prompt);
    if (typeof(T) == typeof(int))
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