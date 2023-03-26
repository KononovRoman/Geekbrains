//                                            HOMEWORK_9

//Task_64
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

/*int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNumberFromN(int N)
{
    if(N == 0)
    {
        return;
    }
    System.Console.Write($"{N} ");
    PrintNumberFromN(N - 1);
}

int N = Prompt("Input natural number: ");

PrintNumberFromN(N);*/


//*****************************************************************************************************************************


//Task_66
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

/*int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbersFromMToN(int fromNumber, int toNumber)
{
    if(toNumber == fromNumber - 1)
    {
        return 0;
    }
    return toNumber + SumNumbersFromMToN(fromNumber, toNumber - 1);
}


int M = Prompt("Input first natural number: ");
int N = Prompt("Input second natural number: ");

Console.WriteLine($"Сумма чисел от {M} до {N} включительно = {SumNumbersFromMToN(M,N)}");*/


//*****************************************************************************************************************************


//Task_68
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int AccermanFunction (int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return AccermanFunction(m-1, 1);
    else return AccermanFunction(m-1, AccermanFunction(m, n-1));
}


int m = Prompt("Input first natural number: ");
int n = Prompt("Input second natural number: ");

Console.WriteLine(AccermanFunction(m, n));