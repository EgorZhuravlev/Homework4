/* Напишите программу, которая принимает на вход два числа (A и B) и 
метод который возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль. Не использовать Math.Pow()
 */

bool isParsedA = int.TryParse(Console.ReadLine(), out int A);
bool isParsedB = int.TryParse(Console.ReadLine(), out int B);
if (!isParsedA || !isParsedB)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}

int Exponent = GettingExponent(A, B);

Console.WriteLine(Exponent);



int GettingExponent(int A, int B)
{
    int count = 1;
    int result = A;
    while (count < B)
    {
        result = result * A;
        count++;
    } 
    return result;
}