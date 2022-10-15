/* Напишите программу, котрая принимает число и выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ??"");
int count = 0;
while(number > 0)
{
    count = count + 1;
    count = number / 10;
}

Console.WriteLine($"Количество цифр в числе {number} = {count}");