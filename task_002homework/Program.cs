// Максимальное и минимальное из двух чисел

int numberA = new Random().Next(1, 11); // 1 2 3 4 ... 10
Console.WriteLine("numberA  " + numberA);

int numberB = new Random().Next(1, 11); // 1 2 3 4 ... 10
Console.WriteLine("numberB  " + numberB);

if (numberA > numberB)
{
    Console.WriteLine("numberA   Является наибольшим числом " + numberA);
    Console.WriteLine("numberB   Является наименьшим числом " + numberB);
}
else
{
    Console.WriteLine("numberA   Является наименьшим числом " + numberA);
    Console.WriteLine("numberB   Является наибольшим числом " + numberB);
}
