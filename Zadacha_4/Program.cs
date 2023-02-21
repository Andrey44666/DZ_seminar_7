// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Matrix = new int[4, 4];

int[,] MatrixSpiralFull(int[,] matrix)
{
    int value = 1;
    int size = Matrix.GetLength(0);
    int maxIndex = size - 1;
    int i = 0;
    int j = 0;

    while (value <= size * size)
    {
        Matrix[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < maxIndex)
            j++;
        else if (i < j && i + j >= maxIndex)
            i++;
        else if (i >= j && i + j > maxIndex)
            j--;
        else
            i--;
    }
    return Matrix;

}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j] + " ");
            }
            else
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

MatrixSpiralFull(Matrix);
Print(Matrix);
