using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var numbers = new[] { 10, 23, 5, 17, 8, 31, 12, 19, 3, 25 };
const int topN = 5;

var topElements = numbers.OrderByDescending(num => num).Take(topN).ToArray();

Console.WriteLine($"Початковий масив: \n{string.Join(" ", numbers)}");
Console.WriteLine($"\nТоп {topN} елементів списку в порядку спадання: \n{string.Join(" ", topElements)}");