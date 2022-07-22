// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int rows = 4, columns = 3;
int[,] array1 = new int[rows, columns];                 //Зададим массив 1 с рандомными числами
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        array1[i, j] = new Random().Next(0, 11);
    }

int[,] array2 = new int[rows, columns];                 //Зададим массив 2 с рандомными числами
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        array2[i, j] = new Random().Next(0, 11);
    }

for (int i = 0; i < rows; i++)                          
{
    for (int j = 0; j < columns; j++)
        Console.Write(String.Format("{0,4}", array1[i, j]));
    Console.WriteLine();
}
Console.WriteLine("-------------------");

for (int i = 0; i < rows; i++)                          
{
    for (int j = 0; j < columns; j++)
        Console.Write(String.Format("{0,4}", array2[i, j]));
    Console.WriteLine();
}

int[,] multipliedArray = new int[rows, columns];                 //Зададим массив 1 с рандомными числами
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        multipliedArray[i, j] = array1[i,j]*array2[i,j];
    }

Console.WriteLine("-------------------");

for (int i = 0; i < rows; i++)                          
{
    for (int j = 0; j < columns; j++)
    Console.Write(String.Format("{0,4}", multipliedArray[i, j]));
    Console.WriteLine();
}