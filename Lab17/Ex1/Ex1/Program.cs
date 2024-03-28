// Варіант #9
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var lengthN = (int)Input("Введіть довжину для масиву X: ");
var lengthM = (int)Input("Введіть довжину для масиву Y: ");

var arrX = new float[lengthN];
var arrY = new float[lengthM];

InputArray(arrX, "\nВведіть значення для масиву X: ");
InputArray(arrY, "\nВведіть значення для масиву Y: ");

var resX = Sum(arrX, Math.Sin, Math.Cos, Math.Tan, true);
var resY = Sum(arrY, Math.Tan, Math.Exp, Math.Cos);

Console.WriteLine($"\nЗначення масиву X: [{string.Join(", ", arrX)}]");
Console.WriteLine($"Значення масиву Y: [{string.Join(", ", arrY)}]");

var finalRes = (resX.aOrD * Math.Sin(resX.bOrE) + resX.bOrE * Math.Cos(resX.cOrF)) / (resY.aOrD + resY.bOrE *
    Math.Sin(resY.cOrF));

Console.WriteLine($"\nРозрахований результат: {finalRes:f5}");

return;

void InputArray(float[] arr, string prompt)
{
    Console.WriteLine(prompt);
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Input($"Введіть значення [{i}]: ");
}

(float aOrD, float bOrE, float cOrF) Sum(float[] arr, Func<double, double> func1, Func<double, double> func2,
    Func<double, double> func3, bool useSnP = false)
{
    float s = arr.Sum();
    float p = arr.Aggregate(1F, (acc, num) => acc * num);
    
    float sum1 = (float)arr.Sum(num => num * func1(num));
    float sum2 = (float)arr.Sum(num => num * func2(num));
    float sum3 = (float)arr.Sum(num => num * func3(num));
    
    return useSnP ? (p * sum1, s * sum2, (p + s) * sum3) : (sum1, sum2, sum3);
}

float Input(string prompt)
{
    float result;
    
    Console.Write(prompt);
    while(!float.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}