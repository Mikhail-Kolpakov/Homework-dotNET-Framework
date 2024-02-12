using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть значення варіант формули, за яким бажаєте провести розрахунки: ");
Console.WriteLine("1/first) z = sin(x)^2");
Console.WriteLine("2/second) z = log(x)^2");
Console.WriteLine("3/third) z = 1 / cos(x^3)");

var (x, formula) = InputAndCheck();

Console.WriteLine($"\nРезультат: {Calculate(x, formula):f5}");

return;

(float x, string formula) InputAndCheck()
{
    formula = Console.ReadLine()!.ToLower();
    CheckFormula(ref formula);
    
    while (true)
    {
        x = InputX(formula is "second" or "2" ? "Введіть значення X: " : "Введіть значення X (градуси): ");

        switch (x)
        {
            case < 0 when formula is "second" or "2":
                Console.WriteLine("Помилка: значення X повинно бути більше 0");
                continue;
            case var _ when Math.Pow(x, 3) is < -1 or > 1 && formula is "third" or "3":
                Console.WriteLine("Помилка: значення X повинно бути в межах від -1 до 1");
                continue;
            case var _ when Math.Abs(Math.Cos(Math.Pow(x, 3) * Math.PI / 180)) < 0.000001f && formula is "third" or "3":
                Console.WriteLine("Помилка: значення знаменника не може бути 0");
                continue;
            default:
                return (x, formula);
        }
    }
}

void CheckFormula(ref string formula)
{
    while (formula.ToLower() is not "first" and not "second" and not "third" and not "1" and not "2" and not "3")
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
    "first" or "1" => (float)Math.Pow(Math.Sin(x * Math.PI / 180), 2),
    "second" or "2" => (float)Math.Pow(Math.Log(x, 10), 2),
    "third" or "3" => (float)(1 / Math.Cos(Math.Pow(x, 3) * Math.PI / 180)),
    _ => throw new ArgumentException("Невідомий варіант формули")
};