// Написать программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символы 'q' или при вводе числа, сумма цифр 
// которого четная

Console.Clear();
void GenerateArray(int[] arr, string num)
{
    for (int i = 0; i < num.Length; i++)
    {
        arr[i] = (int)char.GetNumericValue(num[i]);
    }
}

bool IsEvenSum(int[] arr)
{
    int sum = 0;
    foreach (int digit in arr)
    {
        sum += digit;
    }
    return sum % 2 == 0;
}

Console.Write("Continue entering an integer until the program stops. You can stop the program by pressing the 'q' button or until the sum of the digits of your number is even: ");
string input = "";

do 
{
    input = Console.ReadLine();
    if (input.ToLower()=="q") 
    {
        Console.WriteLine("[STOP]");
        break;
    }

    int number;
    if (int.TryParse(input, out number))
    {
        string numStr = number.ToString();
        int length = numStr.Length;
        int[] array = new int[length];

        GenerateArray(array, numStr);
        bool isEven = IsEvenSum(array);

        if (isEven)
        {
            Console.WriteLine("[STOP]");
            break;
        }
    } 
} while (true);