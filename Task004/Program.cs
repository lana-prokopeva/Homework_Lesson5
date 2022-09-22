// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// Находим разницу между макс. и мин. элементом
double GetDifferenceBetweenMaxAndMin(double [] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i]>max) max = array[i];
        else min = array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    double difference = max - min;
    return difference;
}

// Задаем массив вещественных чисел
Console.WriteLine($"Массив: ");
double [] RandomNumbers = new double[10];
var random = new Random();
for( int i = 0; i < RandomNumbers.Length; i++)
{
    RandomNumbers[i] = Math.Round(random.NextDouble()*100, 2);
    Console.Write($"{RandomNumbers[i]}  ");
}

double DifferenceBetweenMaxAndMin = GetDifferenceBetweenMaxAndMin(RandomNumbers);
Console.WriteLine($"Разница между max и min значением массива = {Math.Round(DifferenceBetweenMaxAndMin, 2)}");