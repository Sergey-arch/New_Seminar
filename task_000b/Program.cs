// Вывести квадрат числа (Print the square of the number)

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); // Запрос цифры на ввод и
                                               // конвертировать строку в цифру
int square = num * num;

Console.WriteLine("Ответ: " + square);