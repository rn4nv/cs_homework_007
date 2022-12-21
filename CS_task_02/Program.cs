Console.Clear();

void FillArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ElementSearch (int [,] matrix, int arg1, int arg2)
{
    int i = matrix.GetLength(0);
    int j = matrix.GetLength(1);
    if (i > arg1 && j > arg2)
    {
        Console.Write("Элемент с введенной позицией в массиве найден и равен: ");
        Console.Write(matrix[arg1, arg2]);
    }
    else
    {
        Console.WriteLine("Элемент с введенной позицией в массиве не найден, запустите программу заново и введите другую позицию элемента.");
    }
    return arg1;
    return arg2;
}

int[,] array = new int [3,4];
Console.Write("Введите позицию искомого элемента. Строка №: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите позицию искомого элемента. Столбец №: ");
int n = int.Parse(Console.ReadLine());

FillArray(array);
PrintArray(array);
ElementSearch(array,m,n);

