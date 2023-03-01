 //HomeTask_10
 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

 /*int SecondNumber (int num)
 {
    return num / 10 % 10;
 }

int number = 0;

while (number < 99 || number > 999)
{
    Console.WriteLine("Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

 Console.WriteLine("Вторая цифра данного цисла = " + SecondNumber(number));*/




 //HomeTask_13
 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


/*void ThirdNumber (int num)
{
    if (num > -100 && num < 100) 
        Console.WriteLine("Третьей цифры в данном числе нет!");
    else 
    {
        while (num > 999 || num < -999)
        {
            num = num / 10;
        }

        Console.WriteLine("Третья цифра данного числа = " + Math.Abs(num%10));    
    }
}

    Console.WriteLine("Введите целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());

ThirdNumber (number);*/




//HomeTask_13
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

bool Weekend (int num)
{
    if (num == 6 || num == 7)
        return true;
    else
        return false;
}

int number = 0;

while (number < 1 || number > 7)
{
    Console.WriteLine("Введите порядковый номер дня недели (от 1 до 7 включительно): ");
    number = Convert.ToInt32(Console.ReadLine());
}

if (Weekend(number)== true)
    Console.WriteLine("Этот день - выходной день!");
else
    Console.WriteLine("Этот день - рабочий день!");

