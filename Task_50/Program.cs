// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



void FillMatrixRnd(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 100);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void CheckMatrixNumber(int[,] matrix, int number)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            { 
                System.Console.WriteLine($"[{i}, {j}]");
                count++;
            }
            
        }
    }
    if (count == 0) System.Console.WriteLine("Данное число не найдено в массиве");
}

void CheckMatrixIndex(int[,] matrix, int row, int colomn)
{
    if (matrix.GetLength(0) < row || matrix.GetLength(1) < colomn) System.Console.WriteLine("Выход за пределы массива");
    else System.Console.WriteLine(matrix[row, colomn]);
}

System.Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, colomn];

FillMatrixRnd(matrix);
PrintMatrix(matrix);

System.Console.Write("Что будем Искать? 1 если номер по индексу, 0 если интекс по номеру: ");
int findWhat = Convert.ToInt32(Console.ReadLine());

if (findWhat == 0)
{
    System.Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    CheckMatrixNumber(matrix, number);
}
else if (findWhat == 1)
{
    System.Console.WriteLine("Введите индекс 1: ");
    int indexRow = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите индекс 2: ");
    int indexColomn = Convert.ToInt32(Console.ReadLine());
    CheckMatrixIndex(matrix, indexRow, indexColomn);
}
else
{
    System.Console.Write("Ошибка ввода данных.");
}
    

