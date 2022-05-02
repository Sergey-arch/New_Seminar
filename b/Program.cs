// Заполнить массив рандомными числами

int[] numbers = new int[5];

FillIntArray(numbers);

void FillIntArray(int[] array)
{
    int index = 0;
    while (index < numbers.Length)
    {
        numbers[index] = new Random().Next(0, 100);
        index++;
    }
}
