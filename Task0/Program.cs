// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введи пятизначное число и получи ответ, является ли оно палиндромом :  ");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrome(int num)
{
    int temp = num;
    int rez = 0;

    while (num > 0)
    {
        int dq = num % 10;
        rez = rez * 10 + dq;
        num = num / 10;
    }
    if (temp == rez)
        Console.WriteLine("да");
    else
        Console.WriteLine(" нет");
}
// if (number > 9999 && number < 100000)
// {
Palindrome(number);
// }
// else Console.WriteLine("Введено неверное число, повтори ввод");

