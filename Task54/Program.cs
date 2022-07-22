// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = 5, columns = 6;
int[,] array = new int[rows, columns];                 //Зададим массив с рандомными числами

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(0, 11);
    }


for (int i = 0; i < rows; i++)                           //Выведеем массив в терминал
{
    for (int j = 0; j < columns; j++)
        Console.Write(String.Format("{0,4}", array[i, j]));
    Console.WriteLine();
}


System.Console.WriteLine("///");


for (int i = 0; i < rows; i++)
{
    int size = columns-1,
    indexRightEdge = size,
    maxRowNumber = 0,
    indexMaxRowNumber = 0,
    indexCount=0,
    replacementNumber;

    for (int j = 0; j < columns; j++)
    {
        while (indexRightEdge > 0)
        {
            while (indexCount <= size)
            {
                if (array[i, indexCount] > maxRowNumber)
                {
                    maxRowNumber = array[i, indexCount];
                    indexMaxRowNumber = indexCount;
                }
                indexCount++;
            }
            replacementNumber = array[i, indexRightEdge];
            array[i, indexRightEdge] = array[i, indexMaxRowNumber];
            array[i, indexMaxRowNumber] = replacementNumber;
            indexRightEdge -= 1;
            size -= 1;
            maxRowNumber = 0;
            indexCount=0;
        }
    }
}


for (int i = 0; i < rows; i++)                           
{
    for (int j = 0; j < columns; j++)
        Console.Write(String.Format("{0,4}", array[i, j]));
    Console.WriteLine();
}
