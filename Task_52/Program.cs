// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrixRnd(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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

void FindMidleInColomn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        int count = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
            count++;
        }
        System.Console.WriteLine($"Столбец №{i} среднее арифметическое = {sum / count}");
    }
}


System.Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, colomn];
FillMatrixRnd(matrix);
PrintMatrix(matrix);
FindMidleInColomn(matrix);