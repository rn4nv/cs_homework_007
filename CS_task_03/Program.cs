Console.Clear();

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// double SumNum(int[,] matrix)
// {
//     double result0 = 0;
//     double result1 = 0;
//     double result2 = 0;
//     double result3 = 0;
//     for (int i = 0, j = 0; i < matrix.GetLength(1); i++)
//     {
//         result0 = result0 + matrix[i,j];
//     }
//     double ArithmeticMean0 = result0 / matrix.GetLength(1);
//     for (int i = 0, j = 1; i < matrix.GetLength(1); i++)
//     {
//         result1 = result1 + matrix[i,j];
//     }
//     double ArithmeticMean1 = result1 / matrix.GetLength(1);
//     for (int i = 0, j = 2; i < matrix.GetLength(1); i++)
//     {
//         result2 = result2 + matrix[i,j];
//     }
//     double ArithmeticMean2 = result2 / matrix.GetLength(1);
//     for (int i = 0, j = 3; i < matrix.GetLength(1); i++)
//     {
//         result3 = result3 + matrix[i,j];
//     } 
//     Console.WriteLine();
//     double ArithmeticMean3 = result3 / matrix.GetLength(1);
//     Console.Write($"{ArithmeticMean0},{ArithmeticMean1},{ArithmeticMean2},{ArithmeticMean3}");
//     return result0;

// }
void MeanArithColumn(int [,] matr)
{
    double summ=0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            summ += matr[j, i];
        }
        Console.WriteLine($"Среднее арифмитическое {i+1} солбца равно {summ/matr.GetLength(0)}");
    }
}

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
MeanArithColumn(array);