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

