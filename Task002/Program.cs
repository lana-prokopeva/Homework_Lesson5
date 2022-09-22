// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Определяем сумму элементов с нечетным индексом
int GetSumElementsWhithOddIndex (int [] array)
{
    Console.WriteLine();
    Console.WriteLine("Значения элементов с нечетным индексом: ");
    int sum = 0;
    for( int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
        Console.Write($"{array[i]} ");
    }
    return sum;
}

// Задаем массив
Console.WriteLine("Массив: ");
int [] RandomNumbers = new int [10];
var random = new Random();
for(int i = 0; i < RandomNumbers.Length; i++)
{
    RandomNumbers[i] = random.Next(0, 10);
    Console.Write($"{RandomNumbers[i]} ");
}

int SumElementsWhithOddIndex = GetSumElementsWhithOddIndex(RandomNumbers);
Console.WriteLine();
Console.Write($"Сумма элементов с нечетным индексом = {SumElementsWhithOddIndex}");