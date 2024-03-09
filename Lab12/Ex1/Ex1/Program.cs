using System.Text;

Console.OutputEncoding = Encoding.UTF8;

const string inputFilePath = "files/inputData.txt";
const string outputFilePath = "files/results.txt";
float xMin, xMax, dx, k;

using(var reader = new StreamReader(inputFilePath))
{
    try
    {
        xMin = Convert.ToSingle(await reader.ReadLineAsync());
        xMax = Convert.ToSingle(await reader.ReadLineAsync());
        dx = Convert.ToSingle(await reader.ReadLineAsync());
        k = Convert.ToSingle(await reader.ReadLineAsync());
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nПри зчитування данних з файлу виникла помилка: \n{ex.Message}");
        return;
    }
    
    Console.WriteLine("Дані були успішно зчитані з файлу.");
}

await using (var writer = new StreamWriter(outputFilePath, false))
{
    const float epsilon = 1e-4F;
    
    for (float x = xMin; x - xMax <= epsilon; x += dx)
        await writer.WriteLineAsync($"При x = {x:f3} Z дорівнює {MyFunction(x, k):f3}");

    Console.WriteLine("Результати були успішно записані у файл.");
}

return;

float MyFunction(float x, float k) =>
    (float)(Math.Pow(1 / Math.Tan(k * x), 1.0 / 3.0) + Math.Cos(k * x) / Math.Log(Math.Sin(k * x)));