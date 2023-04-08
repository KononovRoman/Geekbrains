string[] initialArray = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

int CountElementsWithLength(string[] array, int lenMax)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lenMax)
            count++;
    }

    return count;
};

string[] NewArrayInit (string[] array, int count, int lenMax)
{
    string[] resultArray = new string[count];

     int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lenMax) 
        {
            resultArray[k] = array[i];
            k++;
        }
    }
    return resultArray;
}


int lenMax = 3;
int newLength = CountElementsWithLength(initialArray, lenMax);

string[] resultArray = NewArrayInit(initialArray, newLength, lenMax);

Console.WriteLine(newLength);

System.Console.WriteLine($"[{string.Join(", ", resultArray)}]");