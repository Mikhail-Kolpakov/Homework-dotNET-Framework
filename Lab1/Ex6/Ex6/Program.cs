using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var upperBound = Input("Введіть верхню межу діапазону: ");
PrintPrimeNumbers(upperBound);

return;

int Input(string prompt)
{
    int result;
    
    Console.Write(prompt);
    while(!int.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}

void PrintPrimeNumbers(int upperBound)
{
    Console.WriteLine($"Прості числа у діапазоні від 1 до {upperBound}: ");
    
    for (int number = 2; number <= upperBound; number++)
    {
        var isPrime = true;
    
        for (int j = 2; j < Math.Sqrt(number); j++)
        {
            if (number % j == 0)
            {
                isPrime = false;
                break;
            }
        }
    
        if (isPrime)
            Console.Write($"{number} ");
    }
}