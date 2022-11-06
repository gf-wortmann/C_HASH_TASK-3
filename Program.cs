//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//
using System;

//definition block
// Functuon for filling the array with 10 powered in an index of the array items.. 1, 10, 100, etc..; 
int[] FillArray (int[] a)
{
    a[0]=1;
    for (int i=1; i < a.Length; i++)
        for (int j = 0; j < i; j++) a[i] = a[i-1] * 10;
    return(a);
}
//
// Function for checking if symmetrically placed digits are equal
bool isPalindrome(int n)
{
    int l = 6, c = (l-1)/2, last_i = l-1; 
    int[] a = new int[l];
    a = FillArray(a);
    for (int i = 0; i < c; i++)
    {        
        if(n % a[i+1] / a[i] != n % a[last_i-i] / a[last_i-i-1]) return false; //the first unequality forces returning the false
    }
    return true; //no unequalities => symmetrically placed digits are equal, returning true
}
//end of definition block
//
//+++++++++++++++++++++
//
//input block/////////////
int intN1;
Console.Clear();
Console.Write("Введите 5-значное число ");
intN1 = int.Parse(Console.ReadLine()!);
//
// end of input block/////////////
//
//=========================
//
//exec block
//
// Checking the entered..
if ((intN1 > 99999) || (intN1 < 10000))
{
    Console.WriteLine("Ой, число не 5-значное ...");
    return;
} 
//
//doing the deal
if (isPalindrome(intN1) == true)
    {Console.WriteLine($"Число {intN1} является палиндромом");}
    else
    {Console.WriteLine($"Число {intN1} не является палиндромом");}
//
// end of exec block
