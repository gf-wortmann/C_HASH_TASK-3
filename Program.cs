//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
// А на этой задаче мы не будем заморачиваться с классами. :-) 
//
using System;
//definition block
void ListQubes(int i)
{
    int j = 1;
    while (j <= i)
    {
        if(j!=1)Console.Write(", ");
        Console.Write($"{Math.Pow(j, 3)}");
        j++;
    }
} 
//end of definition block
//input block
int intN1;
Console.Clear();
Console.Write("Введите целое число ");
intN1 = int.Parse(Console.ReadLine()!);
//
// end of input block
//exec block
//
Console.Write($"{intN1} -> ");
ListQubes(intN1);
//
// end of exec block