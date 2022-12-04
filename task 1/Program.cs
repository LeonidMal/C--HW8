/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int GetInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Fill2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] arry)
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

int row = GetInt("Введите количество строк: ");
int column = GetInt("Введите количество столбцов: ");
int[,] array = new int[row, column];
int sum = 0;
int[] sumArray = new int[row];
int index = sumArray[0];

Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();
Sum(array);
ArrayComp(sumArray);
Console.Write($"{index + 1} строка");

void Sum(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            sum = sum + arry[i, j];
        }
        sumArray[i] = (sum);
        sum = 0;
    }
}

void ArrayComp(int[] r)
{
    for (int i = 0; i < 5 - 1; i++)
    {
        if (r[i] > r[i + 1])
            index = i + 1;
    }
}


/*
Console.WriteLine();
PrintArray(sumArray);                           //проверка сумм
void PrintArray(int[] r)
{
    for (int i = 0; i < r.Length; i++)
    {
        Console.Write($"{r[i]} ");
    }
}
*/


