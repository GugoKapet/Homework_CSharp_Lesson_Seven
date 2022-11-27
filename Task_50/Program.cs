// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
//  массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

bool IsParsedM = int.TryParse(Console.ReadLine(), out int m);
bool IsParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsedM || !IsParsedN)
{
    Console.WriteLine("Error!");
    return;
}

int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Insert indexes of the required number:");
int i = Convert.ToInt16(Console.ReadLine());
int j = Convert.ToInt16(Console.ReadLine());
if (i < m && j < m)
{
    Console.WriteLine(matrix[i,j]);
}
else
{
    Console.WriteLine("Number with such indexex does not exist!");
}


void FillMatrix(int[,] m)
{
    Random random = new Random();
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // возвращает кол-во строк в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++) // возвращает кол-во столбцов в массиве  
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}