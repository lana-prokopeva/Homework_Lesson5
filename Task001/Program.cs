// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

// Определяем кол-во четных чисел в массиве

int GetCountEventNumbers(int [] array)
{
    Console.WriteLine();
    Console.WriteLine("Положительные числа массива: ");
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) 
        {
            count = count + 1;
            Console.WriteLine($"{array[i]} ");
        }
    }
    return count;
}

// Задаем массив
int [] RandomeNumbers = new int [10];
var random = new Random();
for(int i = 0; i < RandomeNumbers.Length; i++)
{
    RandomeNumbers[i] = random.Next(100, 1000);
    Console.Write($"{RandomeNumbers[i]} ");
}

int CountEventNumbers = GetCountEventNumbers(RandomeNumbers);
Console.WriteLine($"Количество положительных чисел в массиве = {CountEventNumbers}");