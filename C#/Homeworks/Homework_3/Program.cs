 //                                            HOMEWORK_3
 
 //Task_19
 //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


/*Console.Write("Input 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 9999 || number >= 100000)
{
    Console.Write("It's not 5-digit number. Please try again: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if (number/10000 == number % 10 && number / 1000 % 10 == (number%100) / 10)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}*/


//*****************************************************************************************************************************


 //Task_21
 //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double SquareSubtract (double a, double b)
{
    return Math.Pow(a - b, 2);
}

double Distance3D (double x1, double y1,double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(SquareSubtract(x1,x2)+ SquareSubtract(y1,y2)+SquareSubtract(z1,z2));
    return Math.Round(result,2);
}

Console.Write("Введите координату X для первой точки: x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для первой точки: y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для первой точки: z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X для второй точки: x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для второй точки: y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для второй точки: z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance3D(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Расстояние между заданными точками равно = {distance}");*/


//*****************************************************************************************************************************
