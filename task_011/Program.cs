﻿// Из рандомного трехзначного числа удалить вторую цифру

int numberA = new Random().Next(100, 1000);
Console.WriteLine("numberA = " + numberA);

int n1 = numberA /100 % 10;
int n2 = numberA /10 % 10;
int n3 = numberA % 10;

int numberB = n1* 10 + n3;

Console.WriteLine("Удаленная вторая цифра 3-х значного числа numberA = " + n2);
Console.WriteLine("Первая и третья цифра 3-х значного числа numberA = " + numberB);