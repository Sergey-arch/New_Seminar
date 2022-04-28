// Четные числа от 0 до N (even number  0 to N)

int numberA = new Random().Next(10, 20); // 10, 11, ... 19
Console.WriteLine("numberA = " + numberA);

for (int i = 0; i <= numberA; i++)
{
    if ((i % 2 == 0) && !(i == 1))
    {
        Console.Write(i + ", ");
    }
}