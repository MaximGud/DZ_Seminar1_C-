﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = 0;
if (N < 2)
{
  Console.Write("Нет четных чисел");
}
while (x < N)
{

  x = x + 2;
  if (N-x !=-1)
  {
    Console.Write(x + " ");
  }
}