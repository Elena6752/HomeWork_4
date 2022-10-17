// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
/*
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/
// Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

 Console.WriteLine("Введите размер массива  ");
    
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = rand.Next()%100-50;
    }
    
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    
    int imin = 0, imax = 0;
    
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > array[imax])
            imax = i;
        if (array[i] < array[imin])
            imin = i;
    }
Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {array[imax]}, минимальное значение = {array[imin]}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {array[imax] - array[imin]}");

 