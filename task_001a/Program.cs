// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите число numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine()); // Запрос цифры на ввод и
                                               // конвертировать строку в цифру

Console.Write("Введите число numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine()); // Запрос цифры на ввод и
                                               // конвертировать строку в цифру

if (numberA == numberB * numberB)
{
    Console.WriteLine("numberA   Является квадратом numberB");
}
else
{
    Console.WriteLine("numberA   Не является квадратом numberB");
}