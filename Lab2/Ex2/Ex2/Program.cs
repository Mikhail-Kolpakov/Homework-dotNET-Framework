using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть значення варіант формули, за яким бажаєте провести розрахунки: ");
Console.WriteLine("A/a) z = sqrt(tan(x))");
Console.WriteLine("B/b) z = 1 / tan(x)");
Console.WriteLine("C/c) z = ln(tan(x))\n");

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

        switch (x % 90)
        {
            case 0 when formula is "a" or "b" or "c":
                Console.WriteLine("Помилка: значення кута X не може бути кратне 90");
                continue;
            case var _ when Math.Tan(x * Math.PI / 180) < 0 && formula is "a":
                Console.WriteLine("Помилка: підкореневе значення не може бути від'ємним числом");
                continue;
            case var _ when Math.Tan(x * Math.PI / 180) < 0 && formula is "c":
                Console.WriteLine("Помилка: значення під натуральним логарифмом не может бути від'ємним числом");
                continue;
            default:
                return (x, formula);
        }
    }
}

void CheckFormula(ref string formula)
{
    while (formula.ToLower() is not "a" and not "b" and not "c")
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
    "a" => (float)Math.Sqrt(Math.Tan(x * Math.PI / 180)),
    "b" => (float)(1 / Math.Tan(x * Math.PI / 180)),
    "c" => (float)Math.Log(Math.Tan(x * Math.PI / 180)),
    _ => throw new ArgumentException("Невідомий варіант формули")
};