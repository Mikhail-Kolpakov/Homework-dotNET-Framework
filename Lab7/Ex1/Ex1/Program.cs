using System.Text;

Console.OutputEncoding = Encoding.UTF8;
var aircraftCarriers = new[]
{
    new AircraftCarrier("Гетьман Іван Мазепа", "проведення широкомасштабних морських операцій у зоні підвищеного ризику", 70000, 150000, "дизель", "Ка-27", 35),
    new AircraftCarrier("Фортеця Львів", "контроль за морськими кордонами та боротьба з нелегальними морськими активностями", 40000, 180000, "ядерне паливо", "MQ-9 Reaper", 45),
    new AircraftCarrier("Незламний", "гуманітарні операції та медичні місії", 60000, 120000, "авіагаз", "E-2 Hawkeye", 20),
    new AircraftCarrier("Запорізька Січ", "підтримка морської безпеки та захисту національних морських коридорів", 80000, 200000, "дизель", "CH-47 Chinook", 35),
    new AircraftCarrier("Левітан", "проведення розвідувальних та антитерористичних операцій у різних частинах світу", 75000, 160000, "природній газ", "F-35B Lightning II", 30)
};

var missileCarriers = new[]
{
    new MissileCarrier("Українська Стріла", "забезпечення оборони країни від потенційних загроз", 50000, 100000, "керосин", "SM-3", 40),
    new MissileCarrier("Дніпровський Гром", "забезпечення міжнародної стабільності та врегулювання конфліктів", 55000, 120000, "керосин", "Tomahawk", 16),
    new MissileCarrier("Гайдамацька Вітрила", "забезпечення повітряної безпеки та ведення повітряної боротьби", 40000, 90000, "тверде паливо", "AIM-120 AMRAAM", 20),
    new MissileCarrier("Славута-М", "підтримка повстанців або опозиційних сил у різних країнах", 60000, 140000, "керосин", "Harpoon", 32),
    new MissileCarrier("Карпатська Скеля", "підтримка сил міжнародного співробітництва та обміну інформацією", 52000, 110000, "гібридне паливо", "AGM-158 JASSM", 26)
};

Console.WriteLine("Авіаносці: ");
PrintInfo(aircraftCarriers);

Console.WriteLine("Ракетоносії: ");
PrintInfo(missileCarriers);

return;

void PrintInfo(IEnumerable<Ship> ships)
{
    foreach (var ship in ships)
    {
        Console.WriteLine($"Назва: {ship.Name}");
        Console.WriteLine($"Призначення: {ship.Purpose}");
        Console.WriteLine($"Водотоннажність: {ship.WaterContent} т");
        Console.WriteLine($"Потужність двигуна: {ship.EnginePower} кіловатт");
        Console.WriteLine($"Тип палива: {ship.FuelType}");
        switch (ship)
        {
            case AircraftCarrier aircraftCarrier:
                Console.WriteLine($"Тип літаків: {aircraftCarrier.AircraftType}");
                Console.WriteLine($"Кількість літаків: {aircraftCarrier.AircraftCount}");
                break;
            case MissileCarrier missileCarrier:
                Console.WriteLine($"Тип ракет: {missileCarrier.MissilesType}");
                Console.WriteLine($"Кількість ракет: {missileCarrier.MissilesCount}");
                break;
        }
        Console.WriteLine();
    }
}

internal record Ship(string Name, string Purpose, float WaterContent, float EnginePower, string FuelType);
internal record AircraftCarrier(string Name, string Purpose, float WaterContent, float EnginePower, string FuelType,
    string AircraftType, int AircraftCount) : Ship(Name, Purpose, WaterContent, EnginePower, FuelType);
internal record MissileCarrier(string Name, string Purpose, float WaterContent, float EnginePower, string FuelType, 
    string MissilesType, int MissilesCount) : Ship(Name, Purpose, WaterContent, EnginePower, FuelType);