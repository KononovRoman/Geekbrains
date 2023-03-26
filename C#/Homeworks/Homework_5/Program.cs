//                                            HOMEWORK_5
 
 //Task_25
 //Задайте массив заполненный случайными положительными трёхзначными числами. 
 //Напишите программу, которая покажет количество чётных чисел в массиве.

 /*int[] FillArrayWhithRandomNumber(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int CountEven (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) 
            count++;
    }
    return count;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = FillArrayWhithRandomNumber(size);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в заданном массиве = {CountEven(array)}");*/


//*****************************************************************************************************************************


//Task_36
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


/*int[] FillArrayWhithRandomNumber(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = rnd.Next(1, 100);
    }
    return array;
}

int SumOdd (int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = FillArrayWhithRandomNumber(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"Сумма нечетных элементов данного массива = {SumOdd(array)}");*/


//*****************************************************************************************************************************


//Task_38
//Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива

double[] FillArrayWhithRandomNumber(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = Math.Round(rnd.NextDouble(),2);
    }
    return array;
}

/*double RangeArray_1 (double [] arr)
{
    return arr.Max() - arr.Min(); 
}*/

double MaxArray (double[] arr)
{
    double Max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {   
        if (arr[i] > Max) Max = arr[i];
    }
    return Max;
}

double MinArray (double[] arr)
{
    double Min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {   
        if (arr[i] < Min) Min = arr[i];
    }
    return Min;
}


Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] array = FillArrayWhithRandomNumber(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"Максимальный элемент данного массива = {MaxArray(array)}");
Console.WriteLine($"Минимальный элемент данного массива = {MinArray(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами данного массива = {MaxArray(array)-MinArray(array)}");
