// Варіант #8
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var lengthN = (int)Input("Введіть довжину для масиву X: ");
var lengthM = (int)Input("Введіть довжину для масиву Y: ");

var arrX = new float[lengthN];
var arrY = new float[lengthM];

InputArray(arrX, "\nВведіть значення для масиву X: ");
InputArray(arrY, "\nВведіть значення для масиву Y: ");

var resX = Sum(arrX, Math.Sin, Math.Sin, Math.Cos);
var resY = Sum(arrY, Math.Tan, Math.Cos, Math.Sin);

Console.WriteLine($"\nЗначення масиву X: [{string.Join(", ", arrX)}]");
Console.WriteLine($"Значення масиву Y: [{string.Join(", ", arrY)}]");

if (Math.Abs(resY.aOrD * Math.Sin(resY.bOrE) + resY.cOrF) < 1e-10)
{
    Console.WriteLine("\nДілення на нуль неможливе.");
    return;
}

var finalRes = (resX.aOrD * Math.Tan(resX.bOrE) + resX.cOrF) / (resY.aOrD * Math.Sin(resY.bOrE) + resY.cOrF);

Console.WriteLine($"\nРозрахований результат: {finalRes:f5}");

return;

void InputArray(float[] arr, string prompt)
{
    Console.WriteLine(prompt);
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Input($"Введіть значення [{i}]: ");
}

(float aOrD, float bOrE, float cOrF) Sum(float[] arr, Func<double, double> func1, Func<double, double> func2,
    Func<double, double> func3)
{
    var s = arr.Sum();

    var sum1 = (float)arr.Sum(num => num * func1(num));
    var sum2 = arr.Aggregate(1F, (acc, num) => acc * num * (float)func2(num));
    var sum3 = (float)arr.Sum(num => num * func3(num));

    return (s * sum1, sum2, s * sum3);
}

float Input(string prompt)
{
    float result;

    Console.Write(prompt);
    while (!float.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}