/* Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */


bool isParsedX = int.TryParse(Console.ReadLine(), out int X);
if (!isParsedX)
{
    Console.WriteLine("Данные ввели некорректно");
    return;
}

int result = Digit (X);

Console.WriteLine(result);

int Digit (int X)
{
    int sumDigit = 0;
    
    while (X > 0)
    {
        int digit = X % 10;
        sumDigit = sumDigit + digit;
        X = X / 10;
    }
    return sumDigit;
}