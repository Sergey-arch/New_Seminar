// Чётное число (even number)

int numberA = new Random().Next(1, 1000); // 1, 2, ... 999
Console.WriteLine("numberA = " + numberA);

if (numberA % 2 == 0)
{
    Console.WriteLine("число numberA = " + numberA + " - Является четным");
}
else
{
    Console.WriteLine("число numberA = " + numberA + " - Не является четным");
}