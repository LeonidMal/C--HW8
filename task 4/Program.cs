/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int GetInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInt("Введите размер массива: ");
int[,] array = new int [size, size];
int value = 1;
int row = 0;
int column = 0;

FillArray(array);
PrintArray(array);

void FillArray (int[,] arr)
{
    while (value <= size * size)
    {
        array[row,column] = value++;
        if (row <= column + 1 && row + column < size - 1)
            column++;
        else if (row < column && row + column >= size -1)
            row++;
        else if (row >= column && row + column > size - 1)
            column--;
        else
            row--;
    }
}

void PrintArray(int[,] array)
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