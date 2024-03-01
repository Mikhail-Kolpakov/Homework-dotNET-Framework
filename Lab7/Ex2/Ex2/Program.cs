// Варіант #9
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Toy toy = new Toy("Ведмедик Фрайді", 15.99, 3);
toy.Display();

DairyProduct milk = new DairyProduct("Молоко", 2.49, DateTime.Now.AddDays(7));
milk.Display();

// Базовий клас Товар
internal class Goods(string name, double price)
{
    protected string Name { get; } = name;
    protected double Price { get; } = price;

    public virtual void Display() =>
        Console.WriteLine($"Назва: {Name}, Ціна: {Price}$");
}

// Похідний клас Продукт
internal class Product(string name, double price) : Goods(name, price)
{
    public override void Display() =>
        Console.WriteLine($"Продукт - Назва: {Name}, Ціна: {Price}$");
}

// Похідний клас Іграшка
internal class Toy(string name, double price, int ageRestriction) : Product(name, price)
{
    private int AgeRestriction { get; } = ageRestriction;

    public override void Display() =>
        Console.WriteLine($"Іграшка - Назва: {Name}, Ціна: {Price}$, Вікове обмеження: {AgeRestriction}+ роки");
}

// Похідний клас Молочний Продукт
internal class DairyProduct(string name, double price, DateTime expiryDate) : Product(name, price)
{
    private DateTime ExpiryDate { get; } = expiryDate;

    public override void Display() =>
        Console.WriteLine($"Молочний продукт - Назва: {Name}, Ціна: {Price}$, Вжити до: {ExpiryDate.ToShortDateString()}");
}