using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var a = Input("Введіть значення для a: ");
var k = Input("Введіть значення для k: ");
var xmin = Input("Введіть значення для xmin: ");
var xmax = Input("Введіть значення для xmax: ");

while (xmin > xmax)
{
    Console.WriteLine("xmin має бути менше xmax. Спробуйте ще раз: ");
    xmin = Input("Введіть значення для xmin: ");
    xmax = Input("Введіть значення для xmax: ");
}

var dx = Input("Введіть значення для dx: ");

Console.WriteLine();

Function(xmin, xmax, dx, a);

return;

float Input(string prompt)
{
    float result;
    
    Console.Write(prompt);
    while(!float.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}

void Function(float xmin, float xmax, float dx, float a)
{
    for (float x = xmin; x <= xmax; x += dx)
    {
        switch (a * x)
        {
            case < -1 or > 1:
                Console.WriteLine("Помилка: під косинусом значення виходить за межі [-1; 1]. Пропускаємо це значення x");
                continue;
            case < 0:
                Console.WriteLine("Помилка: під логарифмом виходить від'ємне число. Пропускаємо це значення x");
                continue;
            default:
                if (Math.Log(a * x) == 0)
                {
                    Console.WriteLine("Помилка: під знаменнику дробу виходить 0. Пропускаємо це значення x");
                    continue;
                }
                break;
        }
        
        
        float result = (float)(Math.Pow(Math.Cos(a * x), 1F / 3) + k * Math.Cos(a * x) / Math.Log(a * x));
        Console.WriteLine($"При x = {x:f2} результат: {result:f5}");
    }
}