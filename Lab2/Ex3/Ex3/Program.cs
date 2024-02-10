using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть значення варіант формули, за яким бажаєте провести розрахунки: ");
Console.WriteLine("100/A) z = sqrt(sin(x))");
Console.WriteLine("200/B) z = 1 / cos(x)");
Console.WriteLine("250/C) z = ln(abs(tan(x)))\n");

var (x, formula) = InputAndCheck();

Console.WriteLine($"\nРезультат: {Calculate(x, formula):f5}");

return;

(float x, string formula) InputAndCheck()
{
    formula = Console.ReadLine()!.ToLower();
    CheckFormula(ref formula);
    
    while (true)
    {
        x = InputX("Введіть значення X (градуси): ");

        switch (formula)
        {
            case "a" or "100" when Math.Sin(x * Math.PI / 180) < 0:
                Console.WriteLine("Помилка: підкореневе значення не може бути від'ємним числом");
                continue;
            case "b" or "200" when Math.Abs(Math.Cos(x * Math.PI / 180)) < 0.000001f:
                Console.WriteLine("Помилка: значення знаменника не може бути 0");
                continue;
            case "c" or "250" when x % 90 == 0:
                Console.WriteLine("Помилка: значення кута X не може бути кратне 90");
                continue;
            case "c" or "250" when Math.Tan(x * Math.PI / 180) < 0:
                Console.WriteLine("Помилка: значення під натуральним логарифмом не может бути від'ємним числом");
                continue;
            default:
                return (x, formula);
        }
    }
}

void CheckFormula(ref string formula)
{
    while (formula.ToLower() is not "a" and not "b" and not "c" and not "100" and not "200" and not "250")
    {
        Console.WriteLine("Помилка: введіть коректне значення варіанту формули.");
        formula = Console.ReadLine()!;
    }
}

float InputX(string prompt)
{
    float result;
    
    Console.Write(prompt);
    while(!float.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}

float Calculate(float x, string formula) => formula.ToLower() switch {
    "a" or "100" => (float)Math.Sqrt(Math.Sin(x * Math.PI / 180)),
    "b" or "200" => (float)(1 / Math.Cos(x * Math.PI / 180)),
    "c" or "250" => (float)Math.Log(Math.Abs(Math.Tan(x * Math.PI / 180))),
    _ => throw new ArgumentException("Невідомий варіант формули")
};