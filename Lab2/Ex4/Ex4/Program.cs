using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть значення варіант формули, за яким бажаєте провести розрахунки: ");
Console.WriteLine("1/alfa) z = sqrt(a + sin(x))");
Console.WriteLine("2/beta) z = sqrt(sin(a * x))");
Console.WriteLine("3/gamma) z = ln(a - x)\n");

var a = Input("Введіть значення a: ");
var (x, formula) = InputAndCheck(a);

Console.WriteLine($"\nРезультат: {Calculate(x, a, formula):f5}");

return;

(float x, string formula) InputAndCheck(float a)
{
    formula = Console.ReadLine()!.ToLower();
    CheckFormula(ref formula);
    
    while (true)
    {
        x = Input("Введіть значення X (градуси): ");

        switch (formula)
        {
            case "1" or "alfa" when a + Math.Sin(x * Math.PI / 180) < 0:
                Console.WriteLine("Помилка: підкореневе значення не може бути від'ємним числом");
                continue;
            case "2" or "beta" when Math.Sin(x * Math.PI / 180 * a) < 0:
                Console.WriteLine("Помилка: підкореневе значення не може бути від'ємним числом");
                continue;
            case "3" or "gamma" when a - x < 0.000001f:
                Console.WriteLine("Помилка: значення під натуральним логарифмом не может бути від'ємним числом або 0");
                continue;
            default:
                return (x, formula);
        }
    }
}

void CheckFormula(ref string formula)
{
    while (formula.ToLower() is not "1" and not "2" and not "3" and not "alfa" and not "beta" and not "gamma")
    {
        Console.WriteLine("Помилка: введіть коректне значення варіанту формули.");
        formula = Console.ReadLine()!;
    }
}

float Input(string prompt)
{
    float result;
    
    Console.Write(prompt);
    while(!float.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}

float Calculate(float x, float a, string formula) => formula.ToLower() switch {
    "1" or "alfa" => (float)Math.Sqrt(a + Math.Sin(x * Math.PI / 180)),
    "2" or "beta" => (float)Math.Sin(x * Math.PI / 180 * a),
    "3" or "gamma" => (float)Math.Log(a - x),
    _ => throw new ArgumentException("Невідомий варіант формули")
};