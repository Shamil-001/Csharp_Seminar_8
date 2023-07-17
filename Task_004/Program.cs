// Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int row, int col, int dem, int leftRange, int rightRange)
{
    int[,,] tempMatrix = new int[row, col, dem];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                tempMatrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }
    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            for (int k = 0; k < matrixForPrint.GetLength(2); k++)
            {
                System.Console.Write($" {matrixForPrint[i, j, k]}({i}, {j}, {k}) | " + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите X: ");
int cols = ReadInt("Введите Y: ");
int dem = ReadInt("Введите Z: ");
int leftRange = ReadInt("Введите минимальное значение в массиве: ");
int rightRange = ReadInt("Введите максимальное значение в массиве: ");
int[,,] matrixArray = FillMatrix(rows, cols, dem, leftRange, rightRange);
System.Console.WriteLine();
PrintMatrix(matrixArray);