using System.Text;

Console.OutputEncoding = Encoding.UTF8;

const string matrixFilePath = "files/matrixInput.txt";
const string resultFilePath = "files/resultOutput.txt";

Console.WriteLine("Введіть дані для 1-шої матриці: ");
var rows1 = Input("Кількість рядків: ");
var columns1 = Input("Кількість стовпчиків: ");

Console.WriteLine("\nВведіть дані для 2-гої матриці: ");
var rows2 = Input("Кількість рядків: ");
var columns2 = Input("Кількість стовпчиків: ");

if (columns1 != rows2) 
{
    Console.WriteLine("\nПомилка: кількість стовпчиків 1-шої матриці повинна дорівнювати кількості рядків 2-гої матриці.");
    return;
}

if (!await IsMatrixSizeValid(matrixFilePath, rows1, columns1, rows2, columns2))
{
    Console.WriteLine("\nПомилка: розмір матриці не відповідає введеним значенням.");
    return;
}

var (matrix1, matrix2) = await ReadMatricesFromFile(matrixFilePath, rows1, columns1, rows2, columns2);
var resultMatrix = MultiplyMatrices(matrix1, matrix2);

await WriteMatrixToFile(resultFilePath, resultMatrix);

Console.WriteLine("\nРезультат множення матриць збережено у файлі resultOutput.txt.");
    
return;

async Task<bool> IsMatrixSizeValid(string fileName, int rows1, int columns1, int rows2, int columns2)
{
    int matrixElementsCount = 0;
    int totalElements = rows1 * columns1 + rows2 * columns2;
    using StreamReader reader = new StreamReader(fileName);

    string? line;
    while ((line = await reader.ReadLineAsync()) != null)
    {
        var elements = line.Split([" ", "\t"], StringSplitOptions.RemoveEmptyEntries);
        matrixElementsCount += elements.Length;
    }
    
    return matrixElementsCount == totalElements;
}

async Task<(int[,], int[,])> ReadMatricesFromFile(string filePath, int rows1, int columns1, int rows2, int columns2)
{
    var matrix1 = new int[rows1, columns1];
    var matrix2 = new int[rows2, columns2];
    using var reader = new StreamReader(filePath);

    try
    {
        for (int i = 0; i < rows1; i++)
        {
            var rowValues = (await reader.ReadLineAsync())?.Split(' ');

            if (rowValues == null) 
                continue;
        
            for (int j = 0; j < columns1; j++)
                matrix1[i, j] = int.Parse(rowValues[j]);
        }

        for (int i = 0; i < rows2; i++)
        {
            string[]? rowValues = (await reader.ReadLineAsync())?.Split(' ');

            if (rowValues == null) 
                continue;
        
            for (int j = 0; j < columns2; j++)
                matrix2[i, j] = int.Parse(rowValues[j]);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nПри зчитування данних з файлу виникла помилка: \n{ex.Message}");
        Environment.Exit(1);
    }

    return (matrix1, matrix2);
}

async Task WriteMatrixToFile(string filePath, int[,] matrix)
{
    await using var writer = new StreamWriter(filePath, false);
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            await writer.WriteAsync($"{matrix[i, j]} ");
        
        await writer.WriteLineAsync();
    }
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    var rows1 = matrix1.GetLength(0);
    var columns1 = matrix1.GetLength(1);
    var columns2 = matrix2.GetLength(1);

    var result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
        for (int j = 0; j < columns2; j++)
            for (int k = 0; k < columns1; k++)
                result[i, j] += matrix1[i, k] * matrix2[k, j];

    return result;
}

int Input(string prompt)
{
    int result;
    
    Console.Write(prompt);
    while(!int.TryParse(Console.ReadLine(), out result))
        Console.WriteLine(string.Join(" ", "Помилка: введіть коректне значення.", prompt));

    return result;
}