using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var c = Input("Введіть значення для c: ");
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

Function(xmin, xmax, dx, c);

return;

float Input(string prompt)
{
    float result;
    
    Console.Write(prompt);
    while(!float.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}

void Function(float xmin, float xmax, float dx, float c)
{
    for (float x = xmin; x <= xmax; x += dx)
    {
        if (Math.Pow(x, 2) + 1 < 0)
        {
            Console.WriteLine("Помилка: під логарифмом виходить від'ємне число. Пропускаємо це значення x");
            continue;
        }
        
        float result = (float)(Math.Pow(Math.Pow(c, 2) * Math.Pow(x, 2) + 2, 1F / 3) + Math.Log(Math.Pow(x, 2) + 1) / (2 * Math.PI));
        Console.WriteLine($"При x = {x:f2} результат: {result:f5}");
    }
}
