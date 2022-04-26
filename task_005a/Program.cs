// Показать числа от -N до N

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int i = numberA * -1;

while(i <= numberA)
{
    Console.Write(i);
    i++;
    if(i <= numberA)
    {
        Console.Write(", ");
    }
}




