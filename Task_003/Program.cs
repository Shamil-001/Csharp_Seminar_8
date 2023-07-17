// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 18
// 15 12

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

int[,] ResultPowMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}

void PrintForPowMatrix(int[,] resultMatrix, int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine("Результат умножения матриц: ");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(resultMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int rows1 = ReadInt("Введите количество строк первой матрицы: ");
int cols1 = ReadInt("Введите количество столбцов первой матрицы: ");
int leftRange1 = ReadInt("Введите минимальное значение в первой матрицы: ");
int rightRange1 = ReadInt("Введите максимальное значение в первой матрицы: ");
int rows2 = ReadInt("Введите количество строк второй матрицы: ");
int cols2 = ReadInt("Введите количество столбцов второй матрицы: ");
int leftRange2 = ReadInt("Введите минимальное значение в второй матрицы: ");
int rightRange2 = ReadInt("Введите максимальное значение в второй матрицы: ");
System.Console.WriteLine();
int[,] matrix1 = FillMatrix(rows1, cols1, leftRange1, rightRange1);
int[,] matrix2 = FillMatrix(rows2, cols2, leftRange2, rightRange2);
// int[,] matrix1 = { { 2, 4 }, { 3, 2}};
// int[,] matrix2 = { { 3, 2 }, { 3, 3 }};

PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Умножение матриц невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
    return;
}

int[,] resultMatrix = ResultPowMatrix(matrix1, matrix2);
System.Console.WriteLine();
PrintForPowMatrix(resultMatrix, matrix1, matrix2);