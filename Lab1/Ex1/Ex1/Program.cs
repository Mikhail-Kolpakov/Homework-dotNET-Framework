using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var x = Input("Введіть значення для x: ", x => x >= 0 && 2 * Math.Sin(Math.PI / 3 + x) != 0);
var a = Input("Введіть значення для a: ", _ => true);
var c = Input("Введіть значення для c: ", _ => true);

Console.WriteLine($"\nРезультат розрахунків: {Function(x, a, c):f5}");

return;

float Input(string prompt, Func<float, bool> isValid)
{
    int counter = 0;
    float result;
    
    do
    {
        Console.Write(counter > 0 ? string.Join(" ", "Помилка: введіть коректне значення.", prompt) : prompt);
        counter++;
    } while (!float.TryParse(Console.ReadLine(), out result) || !isValid(result));

    return result;
}

float Function(float x, float a, float c) =>
    (float)(Math.Pow(c * x - a, 1F / 3) + Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x)));