// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int MinimumSumRow(int[,] tempMatrix)
{
    int minSum = int.MaxValue;
    int minSumRow = -1;
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            sum += tempMatrix[i, j];
        }
        if (sum < minSum)
        {
            minSumRow = sum;
            minSumRow = i;
        }
    }
    return minSumRow;
}

void PrintMinimumSumRow(int minSum)
{
            System.Console.Write($"Индекс строки с наименьшей суммой элементов массива: {minSum}");
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int leftRange = ReadInt("Введите минимальное значение в массиве: ");
int rightRange = ReadInt("Введите максимальное значение в массиве: ");
int[,] matrixArray = FillMatrix(rows, cols, leftRange, rightRange);
System.Console.WriteLine();
PrintMatrix(matrixArray);
System.Console.WriteLine();
int minSum = MinimumSumRow(matrixArray);
PrintMinimumSumRow(minSum);
