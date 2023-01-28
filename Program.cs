//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a number rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Convert.ToDouble(new Random().Next(minValue,maxValue)) / 100;
        
    return array;
    
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

            Console.WriteLine();
    }

    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] Create2drandomArray(int rows, int columns, int MinValue, int MaxValue)
{

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Element(int[,] array, int rows, int columns, int numOfRow, int numOfColumn)
{
    if (numOfRow <= rows & numOfRow >= 0 && numOfColumn <= columns & numOfColumn >= 0)
    Console.WriteLine($"Значение этого элемента: {array[numOfRow, numOfColumn]}");
    else Console.WriteLine("Такого элемента нет!");
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число масива: ");
int MinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число масива: ");
int MaxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2drandomArray(rows, columns, MinValue, MaxValue);
Show2dArray(array);

Console.Write("Введите элемент строки: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент столбца: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());

Element(array, rows, columns, numberRow, numberColumn);
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] Create2drandomArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число масива: ");
    int MinValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число масива: ");
    int MaxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumColumns(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sum /= array.GetLength(0);
        Console.Write(sum + "\t");
    }
} 
int[,] newArray = Create2drandomArray();
Show2dArray(newArray);
SumColumns(newArray);
*/