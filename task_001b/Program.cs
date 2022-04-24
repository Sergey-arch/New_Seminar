// По двум заданным числам проверять является ли первое квадратом второго

int numberA = new Random().Next(1, 16); // Случайное число от 1 до 100(1, 101-1)
Console.WriteLine("numberA = " + numberA);

int numberB = new Random().Next(1, 5); // Случайное число от 1 до 10(1, 11-1)
Console.WriteLine("numberB = " + numberB);

if (numberA == numberB * numberB) Console.WriteLine("numberA   Является квадратом numberB");
else Console.WriteLine("numberA   Не является квадратом numberB");