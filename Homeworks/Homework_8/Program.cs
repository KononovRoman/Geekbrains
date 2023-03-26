//                                            HOMEWORK_8

//Task_54
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

/*int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] SortElementInRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int minIndex = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, minIndex]) minIndex = k;
            }

            int current = matrix[i, j];
            matrix[i, j] = matrix[i, minIndex];
            matrix[i, minIndex] = current;
        }
    }
    return matrix;
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");

int[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortElementInRows(matrix));*/


//*****************************************************************************************************************************


//Task_56
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

/*int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

int MinSumStringIndex (int[,] matrix)
{
    int minSum = 10 * matrix.GetLength(1); // в общем случае равно правому краю интервала рандомного заполнения * на кол-во столбцов
    int index = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if (sum < minSum)
        {
             minSum = sum;
             index = i;
        }
    }

    return index;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");

int[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Index of string with min sum = {MinSumStringIndex(matrix)}");*/


//*****************************************************************************************************************************


//Task_60
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

/*int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,,] FillMatrixWithRandom(int row, int col, int time)
{
    int[,,] coob = new int[row, col, time];
    Random rnd = new Random();

    for (int i = 0; i < coob.GetLength(0); i++)
    {
        for (int j = 0; j < coob.GetLength(1); j++)
        {
            for (int k = 0; k < coob.GetLength(2); k++)
            {
                coob[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return coob;
}


void PrintCoob(int[,,] coob)
{
    for (int k = 0; k < coob.GetLength(2); k++)
    {
        for (int i = 0; i < coob.GetLength(0); i++)
        {
            for (int j = 0; j < coob.GetLength(1); j++)
            {    
                Console.Write($"{coob[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        
    }
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");
int time = Prompt("Input quantity of time: ");
Console.WriteLine();

int[,,] coob = FillMatrixWithRandom(rows, cols, time);
PrintCoob(coob);*/


//*****************************************************************************************************************************


//Task_58
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

int[,] MatrixMultiplication(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixAxB = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrixAxB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixAxB.GetLength(1); j++)
        {
            matrixAxB[i, j] = 0;
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                matrixAxB[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }
    return matrixAxB;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int rowsA = Prompt("Input quantity of rows of A matrix: ");
int colsA = Prompt("Input quantity of cols of A matrix : ");
int[,] matrixA = FillMatrixWithRandom(rowsA, colsA);
PrintMatrix(matrixA);
Console.WriteLine();

int rowsB = Prompt("Input quantity of rows of B matrix: ");
int colsB = Prompt("Input quantity of cols of B matrix : ");
int[,] matrixB = FillMatrixWithRandom(rowsB, colsB);
PrintMatrix(matrixB);
Console.WriteLine();

if (colsA == rowsB)
{   
    Console.Write("A x B = \n");
    PrintMatrix(MatrixMultiplication(matrixA, matrixB));
}
else
{
   Console.WriteLine("We cant multiply this matriсes");
}*/


//*****************************************************************************************************************************


//Task_59
//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива

/*int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinElement (int [,] matrix)
{
    int minElement = 10; // в общем случае правая граница интервала рандомного заполнения
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement) minElement = matrix[i,j];
        }
    }
    return MinElement;

}

int RowIndexMinElement (int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number) return i; 
        }
    }     
    return -1;  
}

int ColumnIndexMinElement (int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number) return j; 
        }
    }
    return -1;       
}

int [,] DeleteRowColumn (int [,] matrix, int rowIndex, int columnIndex)
{
    int [,] newMatrix = new int [matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int l = 0;
            if (i != rowIndex && j!= columnIndex)
            {
                newMatrix[k,l] = matrix[i,j];
                l++;
            }
        }
        k++;
    }
    return newMatrix;
}

int rows = Prompt("Input quantity of rows of matrix: ");
int cols = Prompt("Input quantity of cols of matrix : ");
int[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();

RowIndexMinElement(MinElement(matrix));
ColumnIndexMinElement(MinElement(matrix));

Console.WriteLine(RowIndexMinElement(MinElement(matrix)));
Console.WriteLine(ColumnIndexMinElement(MinElement(matrix)));*/

