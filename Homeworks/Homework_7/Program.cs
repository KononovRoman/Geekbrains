//                                            HOMEWORK_5
 
 //Task_52
 //Задайте массив заполненный случайными положительными трёхзначными числами. 

 /*double[,] FillMatrixWithSum(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble()*10,2);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillMatrixWithSum(row, column);
PrintMatrix(matrix);*/


//*****************************************************************************************************************************


//Task_50
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void FindByIndex (int row, int column, int [,] matrix)
{
    if( row < 0 || column < 0 || row >= matrix.GetLength(0) || column >= matrix.GetLength(1)) 
        Console.WriteLine("Элемента с такими индексами в матрице нет!");
    else
        Console.WriteLine($"Элемент с индексами [{row}, {column}] = {matrix[row, column]}");
}

bool FindByElement (int number, int[,] matrix)
{
    bool findFlag = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == number) findFlag = true;
        }
    }
    return findFlag;
}

void PrintFindedElement (int number, int [,] matrix)
{
    Console.WriteLine($"Элемент {number} имеет индексы: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == number) Console.WriteLine($"[{i}, {j}]");
        }
    }
}



Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите индекс искомой строки: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс искомого столбца: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
FindByIndex(rowIndex, columnIndex, matrix);
Console.WriteLine();

Console.Write("Введите элемент, который будем искать: ");
int element = Convert.ToInt32(Console.ReadLine());

if(FindByElement(element, matrix)) 
    PrintFindedElement(element, matrix);
else
    Console.WriteLine($"Элемента {element} в массиве нет!");*/


//*****************************************************************************************************************************


//Task_52
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

/*int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void AvgColumns(int [,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца = ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        Console.Write($"({Math.Round(Convert.ToDouble(sum)/matrix.GetLength(0),2)}) ");
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

Console.WriteLine();
AvgColumns(matrix);*/
