// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Поиск среднее 
// арифметического в отдельном методе. Для создания массива и вывода можно воспользоваться методами из 47 задачи.

bool IsParsedM = int.TryParse(Console.ReadLine(), out int m);
bool IsParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsedM || !IsParsedN)
{
    Console.WriteLine("Error!");
    return;
}

int[,] matrix = new int[m, n];
Random random = new Random();
FillMatrix(matrix);
PrintArray(matrix);
Console.WriteLine();
GetAverageOfColumn(matrix);


void FillMatrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = random.Next(1, 100);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // возвращает кол-во строк в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++) // возвращает кол-во столбцов в массиве  
        {
            Console.Write($"{matr[i, j]} |");
        }
        Console.WriteLine();
    }
}

void GetAverageOfColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        double average = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
            average = (double)sum / m;
        }
        Console.WriteLine($"Среднее арифметическое элементов {i+1} столбца: " + Math.Round(average, 2));
    }
}
