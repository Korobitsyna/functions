/* Напишите программу, которая принимает на вход число А и выдает сумму чисел
от 1 до А.
7->28
4-> 10
8 -> 36 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int GetSumm(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
sum += i;
    }
    return sum;
}
int a = GetNumber("Введите число A");
int sum = GetSumm(a);

Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
