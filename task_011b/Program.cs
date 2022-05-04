int numberA = new Random().Next(100, 1000);
Console.WriteLine("numberA = " + numberA);

int n1 = numberA /100;
int n2 = numberA /10 % 10;
int n3 = numberA % 10;

string numberB = Convert.ToString(n1) + Convert.ToString(n3);

Console.WriteLine("Удаленная вторая цифра 3-х значного числа numberA = " + n2);
Console.WriteLine("Первая и третья цифра 3-х значного числа numberA = " + numberB);