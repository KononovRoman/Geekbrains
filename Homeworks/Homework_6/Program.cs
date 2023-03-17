//                                            HOMEWORK_6
 
 //Task_41
 //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

/*Console.Write("Введите количество чисел  M = : ");
int M = Convert.ToInt32(Console.ReadLine());

int current = 1;
int count = 0;

while (current <= M) 
{
    Console.WriteLine("Введите число = : ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count ++;
    current ++;
}

Console.WriteLine($"Количество положительных чисел = {count}");*/


//*****************************************************************************************************************************


//Task_43
//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

Console.Write("Введите угловой коэфициент первой прямой  k1 = : ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите свободный коэфициент первой прямой  b1 = : ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите угловой коэфициент второй прямой  k2 = : ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите свободный коэфициент второй прямой  b2 = : ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения ({x}, {y})");


дописать с проверками!!!

