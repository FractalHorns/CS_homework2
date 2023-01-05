/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// Homework 25.12.2022
// Задание 10
/*
int Transformation(int num)
{
    int des = num / 10;
    int result = des % 10;

    return result;
}
Console.Write("введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = Transformation(num);
Console.Write($"новое число - {newNum}");
*/

// Задание 13
int newNum2 = 0;
int Transformation(int num)
{
    int result = num % 10;
    return result;
}
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.Write("третьей цифры нет!");
    
}
else if (num > 999)
{
    num = num % 1000;
    newNum2 = num / 100;
    Console.Write($"новое число - {newNum2}");
}
else 
{
    int newNum = Transformation(num);
    Console.Write($"новое число - {newNum}");
}


// Задача 15
/*

bool wknd(int num)
{
    if (num > 0 & num < 6) return false;
    else return true;
}
Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num > 7 || num < 0)
{
Console.Write("NaN");
}
else
{
    Console.Write(wknd(num));
}
*/



