
int elements;
Console.Write("Введите колличество элементов массива: ");
int.TryParse(Console.ReadLine()!, out elements);

string[] array = new string[elements];

for (int i = 0; i < elements; i++)
{
    Console.Write($"Введите элемент под индексом {i} - ");
    array[i] = Console.ReadLine();
}

string[] array2 = new string[array.Length];
void SecondArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array, array2);
Console.WriteLine($"Массив с элементами меньше или равной трем:");
PrintArray(array2);
