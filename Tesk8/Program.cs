﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число , ");
int N = int.Parse(Console.ReadLine()!);
for (int x = 2; x < N + 1; x++)       
if (x%2==0)            
Console.WriteLine(x);