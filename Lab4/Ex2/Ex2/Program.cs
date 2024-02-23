using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var array1 = new[] { 1, 3, 5, 7, 9 };
var array2 = new[] { 2, 4, 6, 8, 10 };

PrintEnumeration(array1, "1-ший масив: ");
PrintEnumeration(array2, "2-гий масив: ");

var result = array1.Concat(array2).OrderBy(x => x).ToArray();

PrintEnumeration(result, "\nОб’єднаний і відсортований масив: ");

return;

void PrintEnumeration(IEnumerable<int> arr, string? explanation = null)
{
    if (explanation is not null)
        Console.WriteLine(explanation);
    
    Console.WriteLine(string.Join(" ", arr));
}