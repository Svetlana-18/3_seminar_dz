// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintQuart(int number1)
{
    for (int i = 1; i <= number1; i++)
        Console.WriteLine($"{i,3} | {i * i * i,4}");
}
if (number < 1)
{
    Console.WriteLine("Введите число больше 1");
    return;
}
PrintQuart(number);