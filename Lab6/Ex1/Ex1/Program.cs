using System.Text;

Console.OutputEncoding = Encoding.UTF8;

const string str1 = "Hello";
const string str2 = "World";
const string str3 = "!";
        
// 1. Об'єднання рядків
string combinedString = string.Concat(str1, " ", str2, str3);
Console.WriteLine($"Об'єднання рядків: {combinedString}");
        
// 2. Вставлення рядків
string insertedString = str1.Insert(3, " inserted ");
Console.WriteLine($"Вставлення рядків: {insertedString}");
        
// 3. Заміна рядків
string replacedString = combinedString.Replace("World", "Planet");
Console.WriteLine($"Заміна рядків: {replacedString}");
        
// 4. Вилучення рядків
string removedString = combinedString.Remove(5, 7);
Console.WriteLine($"Вилучення рядків: {removedString}");
        
// 5. Порівняння двох рядків
int isEqual = string.CompareOrdinal(str1, str2);
Console.WriteLine($"Порівняння двох рядків: {isEqual == 0}");
        
// 6. Порівняння символів із двох рядків, які знаходяться на певних місцях
bool isCharEqual = str1[0] == str2[0];
Console.WriteLine($"Порівняння символів на першій позиції: {isCharEqual}");
        
// 7. Визначення індексу першого входження заданого рядка в інший
int index = combinedString.IndexOf("World", StringComparison.Ordinal);
Console.WriteLine($"Індекс першого входження 'World': {index}");