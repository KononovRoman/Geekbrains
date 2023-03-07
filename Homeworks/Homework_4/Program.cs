//                                            HOMEWORK_4
 
 //Task_25
 //Напишите цикл, который принимает на вход два числа (A, B) и возводит число A в натуральную степень B.

/*int PowFunc (int x, int y)
{
    int res = 1;
    for (int i = 1; i <= y; i++)
    {
        res *= x;
    }
    return res;
}


Console.Write("Введите основание степени (А): ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральную степень (B): ");
int B = Convert.ToInt32(Console.ReadLine());

while (B < 1)
{
    Console.Write("Это не натуральное число, попробуйте ввести еще раз натуральную степень (B): ");
    B = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"{A} в степени {B} = {PowFunc(A, B)}");*/


//*****************************************************************************************************************************


 //Task_27
 //Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

/*int SumDigits(int number)
{
    int res = 0;
    while (number != 0)
    {   
        res += number%10;
        number /= 10;
    }  
    return Math.Abs(res);
}
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {num} = {SumDigits(num)}");*/


//*****************************************************************************************************************************


 //Task_29
 //Напишите программу, которая задает массив из 8 элементов и выводит их на экран
 //(;количество элементов в массиве задает пользователь)

/*int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i+1}й элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

System.Console.Write("Введите кол-во элементов массива (N > 0): ");
int size = Convert.ToInt32(Console.ReadLine());

while (size < 1)
{
    Console.Write("Это не положительное число! Попробуйте еще раз: ");
    size = Convert.ToInt32(Console.ReadLine());
}


int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");*/