using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;

const string correctPassword = "fr4LNNbhpBkz8vVbt5rAZz";

Console.WriteLine("Введіть ваш пароль: ");
string inputPassword = Console.ReadLine()!;

IsPasswordCorrect(correctPassword, inputPassword, "^[a-zA-Z0-9]+$");

return;

void IsPasswordCorrect(string correctPassword, string passwordToCheck, string pattern)
{
    if (!Regex.IsMatch(passwordToCheck, pattern))
        Console.WriteLine("Пароль може містити тільки латинські літери та цифри");
    else if (correctPassword != passwordToCheck)
        Console.WriteLine("Пароль невірний");
    else
        Console.WriteLine("Пароль вірний");
}