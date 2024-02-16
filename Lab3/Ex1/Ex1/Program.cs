// Варіант #9
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var firstArray = InputArray('1');
var secondArray = InputArray('2');
var thirdArray = InputArray('3');

var number = InputValid<float>("\nВведіть число для порівняння: ");

AnalizeArray('1', firstArray, number);
AnalizeArray('2', secondArray, number);
AnalizeArray('3', thirdArray, number);

return;

float[] InputArray(char id)
{
    var n = InputValid<int>($"\nВведіть кількість елементів масиву #{id}: ");
    var array = new float[n];

    for (int i = 0; i < array.Length; i++)
        array[i] = InputValid<float>($"Введіть значення елементу масиву з індексом [{i + 1}]: ");

    return array;
}

void AnalizeArray(char id, float[] array, float number)
{
    var sum = array.AsParallel().Where(x => x > 0 && x < number).Sum();
    var geometricMean = Math.Pow(array.AsParallel().Where(x => x > 0 && x < number).Aggregate(1f, (acc, x) => acc * x),
        1f / array.Count(x => x > 0 && x < number));
    
    Console.WriteLine($"\nМасив #{id}");
    Console.WriteLine($"Сума всіх позитивних чисел в масиві, які менше {number}: {sum:f2}");
    Console.WriteLine($"Середнє геометричне всіх позитивних чисел в масиві, які менше {number}: {geometricMean:f2}");
}

T InputValid<T>(string prompt)
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