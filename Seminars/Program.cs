//                                    SEMINAR_1

//Task_1
//Проверить является ли первое число квадратом второго (числа вводит пользователь)

/*
Console.Write("Input a first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int quad_2 = number_2 * number_2;

if (number_1 == quad_2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/


//*****************************************************************************************************************************


//Task_2
//На вход принимаем N (>0), на выходе выводим все целые от -N до N

/*
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = -N;

while (index <= N)
{
    Console.Write(index + " ");
    index++;
}
*/


//*****************************************************************************************************************************
//*****************************************************************************************************************************


//                                   SEMINAR_2

//Task_1
//

/*int CutNumber(int num)
{
    int hundreds = num / 100;
    int ones = num % 10;

    return hundreds * 10 + ones;
}

int randNumber = new Random().Next(100, 1000);

int result = CutNumber(randNumber);

Console.WriteLine(randNumber);
Console.WriteLine(result);*/

/*bool IsDivided(int number, int firstDIvider, int secondDevider)
{
    if (number % firstDIvider ==0 && number % secondDevider == 0)
        return true;
    else
        return false;

    //return number % firstDIvider ==0 && number % secondDevider == 0;
}

Console.Write("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsDivided(num, div1, div2));*/


//*****************************************************************************************************************************


//Task_2
/*int MaxNumber(int num)
{
    int num1 = num / 10;
    int num2 = num % 10;

    if (num1 > num2)
        return num1;
    else
        return num2;
}


int randNumber = new Random().Next(10, 100);

Console.WriteLine(randNumber);
Console.WriteLine(MaxNumber(randNumber));*/


//*****************************************************************************************************************************
//*****************************************************************************************************************************


//                                    SEMINAR_3

//Task_17
//Напишите программу которая принимает на вход координаты точки (x, y), при чем x!=0, y!=0 и выдает номер четверти плоскости

/*Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("Точка лежит в первой четверти");
}
else if (x < 0 && y > 0)
{
    Console.Write("Точка лежит во второй четверти");
}
else if (x < 0 && y < 0)
{
    Console.Write("Точка лежит в третьей четверти");
}
else if (x > 0 && y < 0)
{
    Console.Write("Точка лежит в четвертой четверти");
}
else
{
    Console.Write("Точка лежит на оси");
}*/


//**************************************************************************************************************************


//Task_18
// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

/*Console.Write("Input quarter ");
int quarter = Convert.ToInt32(Console.ReadLine());
switch (quarter){
    case 1:
    Console.WriteLine("x > 0 && y > 0");
    break;
    case 2:
    Console.WriteLine("x < 0 && y > 0");
    break;
    case 3:
    Console.WriteLine("x < 0 && y < 0");
    break;
    case 4:
    Console.WriteLine("x > 0 && y < 0");
    break;
}*/


//**************************************************************************************************************************


//Task_21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*double Power(double a, double b){
    return Math.Pow((a-b), 2);
}

Console.Write("Input X1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X2 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y1 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Power(x1, x2) + Power(y1, y2));
res = Math.Round(res, 3);
Console.WriteLine($"Расстояние между точками {res}");*/

//double res = Math.Pow(number, 2); // возведение в степень
//double res = Math.Sqrt(number); // извлечение квадратного корня
//res = Math.Round(res, 3); // округление


//**************************************************************************************************************************


//Task_22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*int number = 0;
while (number < 1){
    Console.Write("Input number ");
    number = Convert.ToInt32(Console.ReadLine());
}
int current = 1;
while(current <= number){
    Console.Write(Math.Pow(current, 2) + " ");
    current++;
}*/


//*****************************************************************************************************************************
//*****************************************************************************************************************************




//                                    SEMINAR_4

//Task_24
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*int Sum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum+=i;
    }
    return sum;
}


Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма от 1 до {number} = {Sum(number)}");*/


//**************************************************************************************************************************


//Task_26
//Программа принимает на вход число и выдает количество цифр в числе

/*int NumDel(int number)
{
    int index = number;
    int count = 0;
    while (index != 0)
    {
        index /= 10; 
        count++;
    }
    return count;
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество символов = {NumDel(number)}");*/


//**************************************************************************************************************************


//Task_28
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*int Mult(int A)
{
    int mult = 1;
    for(int i = 1; i <= A; i++)
    {
        mult *= i;
    }
    return mult;
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение от 1 до {number} = {Mult(number)}");*/


//**************************************************************************************************************************


//Task_30
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

/*void FillArray(int[] collection)
{
      int length = collection.Length;
      int index = 0;
      while(index < length)
      {
        collection[index] = new Random().Next(0,2);
        index++;
      }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[8]; //Создай новый массив из 8 эл-тов

FillArray(array);  
PrintArray(array);*/




//*****************************************************************************************************************************
//*****************************************************************************************************************************




//                                    SEMINAR_5

//Task_31
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

/*int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int sumPositive = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
if(array[i] > 0)
{
sumPositive+= array[i];
}
else
{
sumNegative+= array[i];
}
}

System.Console.Write("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Сумма положительных значений равна {sumPositive}, а сумма отрицательных значений равна {sumNegative}");*/


//*****************************************************************************************************************************


//Task_32 
//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

int[] ChangeArray(int[] arr, int size)
{
// Чтобы работать с массивом используем копирования массива в отдельный, чтобы не было изменение изначального
int[] copyArr = new int[size];
for(int i = 0; i < copyArr.Length; i++)
{
copyArr[i] = arr[i];
}

for(int i = 0; i < copyArr.Length; i++)
{
    copyArr[i] *= -1;
}
return copyArr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int[] changeArray = ChangeArray(array, size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"[{string.Join(", ", changeArray)}]");*/


//*****************************************************************************************************************************


//Task_33
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine("Введите число: ");
int search = Convert.ToInt32(Console.ReadLine());

bool isOk = false;
for(int i = 0; i < array.Length; i++)
{
if(search == array[i])
{
isOk = true;
break;
}
}
if(isOk)
{
System.Console.WriteLine("Элемент найден");
}
else
{
System.Console.WriteLine("Элемент не найден");
}

// Второй вариант решения
string result = "No";

for(int i=0; i<array.Length; i++){
if(array[i] == search){
result = "yes";
break;
}
}
System.Console.WriteLine(result);*/


//*****************************************************************************************************************************


//Task_35
//Задайте одномерный массив из N случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 150);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] >= 10 && array[i] <= 99)
{
count++;
}
}
System.Console.WriteLine(count);*/


//*****************************************************************************************************************************


//Task_37
//Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

/*int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 10);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int newLength = array.Length / 2 + array.Length % 2;
int[] newArray = new int[newLength];
for(int i = 0; i < array.Length / 2; i++)
{
newArray[i] = array[i] * array[array.Length - 1 - i];
}
if(array.Length % 2 > 0)
{
newArray[newArray.Length - 1] = array[array.Length / 2];
}
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"[{string.Join(", ", newArray)}]");*/


//*****************************************************************************************************************************
//*****************************************************************************************************************************




//                                    SEMINAR_6

//Task_39
//Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

void ReverseArray(int[] arr)
{
int temp = 0;

for(int i = 0; i < arr.Length/2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");*/


//*****************************************************************************************************************************


//Task_40
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*System.Console.Write("Введите первую сторону треугольника: ");
int AB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую сторону треугольника: ");
int BC = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третью сторону треугольника: ");
int AC = Convert.ToInt32(Console.ReadLine());

if(AB + BC > AC && AB + AC > BC && BC + AC > AB)
{
System.Console.Write("Треугольник существует");
}
else
{
System.Console.Write("Треугольник не существует");
}*/


//*****************************************************************************************************************************


//Task_42
//Напишите программу, которая будет преобразовывать десятичное число в двоичное. (45 -> 101101, 2 -> 10)

/*void PrintBinary(int number)
{
if(number <= 0)
{
return;
}

PrintBinary(number/2);
Console.Write(number%2);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);



// Второй вариант
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int end = 0;
while (num1 > 0)
{
end = num1 % 2;
num1 /= 2;
Console.Write(end);
}



//Третий вариант
int SizeofDif(int num)
{
int count = 0;

while (num > 0)
{
    num /= 2;
    count++;
}

return count;
}

int[] Dif(int num)
{
int[] arr = new int[SizeofDif(num)];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num % 2;
    num /= 2;
}

return arr;
}

int[] Reverse(int[] someArr)
{

for (int i = 0; i < someArr.Length/2; i++)
{
    int temp = someArr[i];
    someArr[i] = someArr[someArr.Length - 1 - i];
    someArr[someArr.Length - 1 - i] = temp;
}

return someArr;
}

int[] result = Dif(2);
Console.WriteLine($"Your array: [{string.Join(", ", result)}]");
int[] newArr = Reverse(result);
Console.WriteLine($"Reverse array: [{string.Join(", ", newArr)}]");*/


//*****************************************************************************************************************************


//Task_44 
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

/*void PrintFibToN(int N)
{
int fib1 = 0;
int fib2 = 1;
int fib3 = 0;
Console.Write("0 1 ");
for(int i = 0; i < N - 2; i++)
{
fib3 = fib1 + fib2;
Console.Write($"{fib3} ");
fib1 = fib2;
fib2 = fib3;
}
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintFibToN(number);



//Второй вариант решения
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for(int i = 2; i < number; i++){
array[i] = array[i-2] + array[i-1];
}
Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");*/


//*****************************************************************************************************************************


//Task_45 
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

int[] CopyArray(int[] arr, int size)
{
int[] copyArr = new int[size];
for(int i = 0; i < copyArr.Length; i++)
{
copyArr[i] = arr[i];
}
return copyArr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
int[] changeArray = CopyArray(array, size);

System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"[{string.Join(", ", changeArray)}]");*/


//                                    SEMINAR_7

//Task_46
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

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


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);*/


//*****************************************************************************************************************************


//Task_48
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.

/*int[,] FillMatrixWithSum(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithSum(row, column);
PrintMatrix(matrix);*/


//Task_49
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/*int[,] FillMatrixWithSum(int row, int column)
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

int [,] ChangeMatrixSqr(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] = matrix[i,j]*matrix[i,j];
        }
    }
    return matrix;
}


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithSum(row, column);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(ChangeMatrixSqr(matrix));*/


//Task_51
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

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

int SumMain (int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i,j];
        }
    }
    return sum;
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
while (row <= 0)
{
    Console.Write("Введите положительное число для строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

while (column <= 0)
{
    Console.Write("Введите положительное число для столбцов: ");
    column = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = FillMatrixWithRandom(row, column);

PrintMatrix(matrix);
Console.Write($"Сумма элементов на главной диагонали = {SumMain(matrix)}: ");*/


