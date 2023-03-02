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

//Task_1
//Напишите программу