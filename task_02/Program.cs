// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
void GenerateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99, 1000);
    }
}

int CheckArray(int[] arr)
{
    int count = 0;
    foreach (int digit in arr)
    {
        if (digit % 2 == 0)
            count++;
    }
    return count;
}

int random = new Random().Next(1,50);
int[] array = new int[random];

GenerateArray(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

int res = CheckArray(array);
Console.WriteLine(res);