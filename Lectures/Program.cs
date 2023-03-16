//Таблица умножения

/*for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}*/


//Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
//маленькие буквы “к” заменить большими “К”,а большие “С” маленькими “с”

/*string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
Console.WriteLine(text);
Console.WriteLine();

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);*/



//Упорядочить массив
/*int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
int count = array.Length
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}
void selectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i+1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) minPosition = j;
{
minPosition = j
}
}
int temporary = array[i]
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);*/


//*****************************************************************************************************************************
//*****************************************************************************************************************************




//                                    LECTURE_3

//Рекурсия и двумерные массивы

string[,] table = new string[2,5];
table[1,2] = "word";
//индексы в двумерных массивах, как и в одномерных начинаются с 0

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}