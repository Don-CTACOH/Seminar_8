/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray()
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int sumElements = Int32.MaxValue;
int MinLine = 0;

int[,] massiv = Fill2DArray();
Print2DArray(massiv);
Console.WriteLine();

for (int i = 0; i < massiv.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        sum = sum + massiv[i, j];        
    }
    if (sum < sumElements)
    {
        sumElements = sum;
        MinLine++;
    }
}
Console.WriteLine($"Сумма элементов = {sumElements}, строка с наименьшей суммой элементов = {MinLine}");