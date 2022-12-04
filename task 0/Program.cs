/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]} ");
        }
        Console.WriteLine();
    }

}

int GetInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int row = GetInt("Введите количество строк: ");
int column = GetInt("Введите количество столбцов: ");

int[,] array = new int[row, column];

FillArray(array);
PrintArray(array);
Console.WriteLine();

SortArray(array);
PrintArray(array);

void SortArray(int[,] ar)
{
    int tempNum = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1) - 1; j++)
        {
            if (ar[i, j] < ar[i, j + 1])
            {
                tempNum = ar[i, j];
                ar[i, j] = ar[i, j + 1];
                ar[i, j + 1] = tempNum;
            }
        }
    }
}