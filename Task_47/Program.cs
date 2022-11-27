// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.
// m и n вводит пользователь в консоль

bool IsParsedM = int.TryParse(Console.ReadLine(), out int m);
bool IsParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsedM || !IsParsedN)
{
    Console.WriteLine("Error!");
    return;
}

double[,] matrix = new double[m, n];
Random random = new Random();
FillMatrix(matrix);
PrintArray(matrix);

void FillMatrix(double[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = (random.Next(1, 100) + Math.Round(random.NextDouble(),2));
        }
    }
}

void PrintArray(double[,] matr)
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