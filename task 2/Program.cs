/*Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


int GetInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInt("Введите глубину: ");
int b = GetInt("Введите количество строк: ");
int c = GetInt("Введите количество столбцов: ");
int max = 90;
int value = 10;
int count = 0;
int[,,] array = new int[a, b, c];
int[] randomNum = new int[max];


if (array.Length > max)
{
    Console.WriteLine("Недопустимый размер");
    return;
}

for (int i = 0; i < max; i++)
{
    randomNum[i] = value++;
}

for (int i = 0; i < max; i++)
{
    int randomI = new Random().Next(0, max);
    int temp = randomNum[randomI];
    randomNum[randomI] = randomNum[i];
    randomNum[i] = temp;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = randomNum[count++];
        }
    }
}

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, k, j]}({i},{k},{j}) ");
        }
        Console.WriteLine();
    }
}