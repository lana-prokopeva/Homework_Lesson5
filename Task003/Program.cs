// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и
// последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// Метод печать массива

int [] PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    return array;
}

// Определяем массив из произведений пар чисел

int [] GetProductPairOfNumbers(int [] array)
{
    int[] arrayProduct = null;
    int i2 = array.Length - 1;
    if(array.Length % 2 == 0)
    {
        arrayProduct = new int[array.Length/2];
        for(int i = 0; i < array.Length/2; i++)
        {
            int product = array[i] * array[i2-i];
            arrayProduct[i] = product;
        }
    }
    else
    {
        arrayProduct = new int[array.Length/2 + 1];
        for(int i = 0; i < array.Length/2 + 1; i++)
        {
            if (i == array.Length/2)
            {
                int product = array[i] * 1;
                arrayProduct[i] = product;
            }
            else
            {
                int product = array[i] * array[i2-i];
                arrayProduct[i] = product;
            }
        }
    }
    return arrayProduct;
}

// Определяем массив
Console.WriteLine("Укажите размер массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = new int[size];
var random = new Random();
for(int i = 0; i < size; i++) array[i] = random.Next(1, 10);

Console.WriteLine("Первоначальный массив: ");
int [] FirstArray = PrintArray(array);
int [] ProductArray = GetProductPairOfNumbers(array);
Console.WriteLine();
Console.WriteLine("Массив произведений пар чисел: ");
int [] SecondArray = PrintArray(ProductArray);

