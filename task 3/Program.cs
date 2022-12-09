/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int GetInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int row = GetInt("Введите количестов строк: ");
int column = GetInt("Введите количестов столбцов: ");
int[,] firstMatrix = new int[row, column];
int[,] secondMatrix = new int[row, column];
int[,] prodMatrix = new int[row, column];


FillMatrix(firstMatrix);
FillMatrix(secondMatrix);

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);

ProdMatrix(firstMatrix, secondMatrix);
Console.WriteLine();
PrintMatrix(prodMatrix);


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ProdMatrix(int[,] fMatrix, int[,] sMatrix)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < column; k++)
            {
                prodMatrix[i,j] += fMatrix[i,k] * sMatrix[k, j];
            }
        }
    }
}
