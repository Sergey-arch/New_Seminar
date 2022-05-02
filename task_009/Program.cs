// Случайное число от 10 до 99 и показать наибольшую цифру числа
// Random number segment from 10 to 99 and show the maximum digit

int numberA = new Random().Next(10, 100); // 10, 11, ... 99
Console.WriteLine("numberA = " + numberA);

int first = numberA / 10; 
int second = numberA % 10;

if(first > second)
{
    Console.WriteLine("max = " + first);
}
else
{
    Console.WriteLine("max = " + second);
}
