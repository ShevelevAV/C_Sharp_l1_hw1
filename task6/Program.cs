﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
double i = N % 2;
if(i == 0){
    Console.WriteLine("Четное");
}else{
    Console.WriteLine("Нечетное");
}
