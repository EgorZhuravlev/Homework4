/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


bool isParsedX = int.TryParse(Console.ReadLine(), out int X);
if (!isParsedX)
{
    Console.WriteLine("Данные ввели некорректно");
}


Random random = new Random();

int[] UserArray = SetArray(X);
PrintArray(UserArray);

int[] SetArray(int X)
{
    int[] MyArr = new int[X];
    for (int i = 0; i < MyArr.Length; i++)
    {
        MyArr[i] = random.Next(0, 100);
    }
    return MyArr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}