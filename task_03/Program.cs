// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

Console.Clear();
void GenerateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 20);
    }
}

void OperationArray(int[] arr, int[] newArr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[arr.Length-1-i];
    }
}

int random = new Random().Next(5,10);
int[] array = new int[random];

GenerateArray(array);
Console.WriteLine(string.Join(", ", array));

int length = array.Length;

int[] newArray = new int[length];
OperationArray(array, newArray);
Console.WriteLine();
Console.WriteLine(string.Join(", ", newArray));