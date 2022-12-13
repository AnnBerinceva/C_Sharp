string[] array1 = new string[10] {"Hello", "2", "world", ")))", "1234", "156", "-2", "Russia", "-8", "abc"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int a = 0; a < array1.Length; a++)
    {
    if(array1[a].Length <= 3)
        {
        array2[count] = array1[a];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int a = 0; a < array.Length; a++)
    {
        Console.Write($"{array[a]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);