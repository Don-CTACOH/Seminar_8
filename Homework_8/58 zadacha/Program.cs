/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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
            array[i, j] = new Random().Next(1, 5);
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

int[,] massiv = Fill2DArray();
int[,] massiv2 = Fill2DArray();
int[,] massiv3 = Fill2DArray();
Print2DArray(massiv);
Console.WriteLine();
Print2DArray(massiv2);
Console.WriteLine();

if (massiv.GetLength(0) != massiv2.GetLength(1))
{
    Console.WriteLine("Матрицы не согласованы");
    return;
}
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv2.GetLength(1); j++)
    {
        massiv3[i, j] = 0;
        for (int k = 0; k < massiv.GetLength(1); k++)
        {
            massiv3[i, j] += massiv[i, k] * massiv2[k, j];
        }
    }
}
Print2DArray(massiv3);