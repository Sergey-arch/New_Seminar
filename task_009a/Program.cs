// Случайное число от 10 до 99 и показать наибольшую цифру числа
// Random number segment from 10 to 99 and show the maximum digit

int number = new Random().Next(10, 100); // 10, 11, ... 99
Console.WriteLine("number = " + number);

int first = number / 10;
int second = number % 10;

int max = MaxNumber(first, second);
Console.WriteLine("max = " + max);

int MaxNumber(int number1, int number2)
{
    int max = number1;
    if (number2 > number1)
    {
        max = number2;
    }
    return max;
}

