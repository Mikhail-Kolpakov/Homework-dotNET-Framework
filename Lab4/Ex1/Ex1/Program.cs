using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var employeesCount = Input("Введіть кількість співробітників: ");
var lowerHeightBound = Input("Введіть нижню межу зросту (см): ");
var upperHeightBound = Input("Введіть верхню межу зросту (см): ");
var lowerWeightBound = Input("Введіть нижню межу ваги (кг): ");
var upperWeightBound = Input("Введіть верхню межу ваги (кг): ");

if (upperHeightBound <= lowerHeightBound || upperWeightBound <= lowerWeightBound)
{
    Console.WriteLine("\nПомилка: верхня межа повинна бути більшою за нижню межу");
    return;
}

var heights = GenerateRandomArray(employeesCount, lowerHeightBound, upperHeightBound);
var weights = GenerateRandomArray(employeesCount, lowerWeightBound, upperWeightBound);

var (sortedHeights, sortedWeights) = SortHeightsAndWeights(heights, weights);

Console.WriteLine();
for (int i = 0; i < employeesCount; i++)
    Console.WriteLine($"{i + 1}-й співробітник) Зріст: {sortedHeights[i]} см, Вага: {sortedWeights[i]} кг");

return;

(int[] heights, int[] weights) SortHeightsAndWeights(int[] heights, int[] weights)
{
    var sortedHeights = heights.OrderBy(h => h).ToArray();
    var sortedWeights = new int[weights.Length];

    for (var i = 0; i < sortedHeights.Length; i++)
    {
        var index = Array.IndexOf(heights, sortedHeights[i]);
        sortedWeights[i] = weights[index];
    }

    return (sortedHeights, sortedWeights);
}

int[] GenerateRandomArray(int length, int lowerBound, int upperBound)
{
    var arr = new int[length];
    var rand = new Random();
    
    for (var i = 0; i < arr.Length; i++)
        arr[i] = rand.Next(lowerBound, upperBound);

    return arr;
}

int Input(string prompt)
{
    int result;
    
    Console.Write(prompt);
    while(!int.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}