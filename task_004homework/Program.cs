// Максимальное из трех чисел

int numberA = new Random().Next(1, 11); // 1 2 3 4 ... 10
Console.WriteLine("numberA  " + numberA);

int numberB = new Random().Next(1, 11); // 1 2 3 4 ... 10
Console.WriteLine("numberB  " + numberB);

int numberС = new Random().Next(1, 11); // 1 2 3 4 ... 10
Console.WriteLine("numberС  " + numberС);

int max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberС > max) max = numberС;

Console.WriteLine("max =  " + max);