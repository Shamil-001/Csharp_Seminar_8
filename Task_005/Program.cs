// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralMatrix(int[,] tempMatrix)
{
    int value = 1; // начальное значение элемента
    int row = 0; // текущая строка
    int col = 0; // текущий столбец
    int size = 4; // текущий размер матрицы
    while (size > 1)
    {
        // заполняем верхнюю строку слева направо
        for (int i = col; i < col + size; i++)
        {
            tempMatrix[row, i] = value;
            value++;
        }
        row++; // переходим на следующую строку

        // заполняем правый столбец сверху вниз
        for (int i = row; i < row + size - 1; i++)
        {
            tempMatrix[i, col + size - 1] = value;
            value++;
        }
        col += size - 1; // переходим на следующий столбец

        if (size == 1) // если остался один элемент, то выходим из цикла
        {
            break;
        }

        // заполняем нижнюю строку справа налево
        for (int i = col - 1; i > col - size; i--)
        {
            tempMatrix[row + size - 2, i] = value;
            value++;
        }
        row += size - 2; // переходим на следующую строку

        // заполняем левый столбец снизу вверх
        for (int i = row - 1; i > row - size + 1; i--)
        {
            tempMatrix[i, col - size + 1] = value;
            value++;
        }
        col -= size - 2; // переходим на следующий столбец
        size -= 2; // уменьшаем размер матрицы на 2
        row -= size; // переходим на следующую строку
    }
    return tempMatrix;
}
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write("{0,3}", matrixForPrint[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
SpiralMatrix(matrix);
PrintMatrix(matrix);