// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

int rows = 5, columns = 3;

int[] arraySumRows = new int[rows];  // Массив с суммами строк двумерного массива

int[,] array = new int[rows, columns];  // Зададим двумерный массив и заполним рандомными числами               

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(0, 11);
    }


for (int i = 0; i < rows; i++)                          
{
    for (int j = 0; j < columns; j++)
        Console.Write(String.Format("{0,4}", array[i, j]));
    Console.WriteLine();
}


int sumRowNumbers = 0;                    // Найдем суммы всех строк и заполним этими значениями arraySumRows[]
for (int i = 0; i < rows; i++)                           
{
    for (int j = 0; j < columns; j++)
    { sumRowNumbers = sumRowNumbers + array[i, j]; }
    arraySumRows[i] = sumRowNumbers;
    sumRowNumbers = 0;
}

var str = string.Join(" ", arraySumRows);     // Выведем значения сумм строк в терминал
Console.WriteLine($"Суммы строк - {str}");

int minArraySumRows = arraySumRows[0];       //Найдем минимальное значение строки и выведем его в терминал
int indexMinArraySumRows = 0;
for (int index = 0; index < rows; index++)
{
    if (arraySumRows[index] < minArraySumRows)
    {
        minArraySumRows = arraySumRows[index];
        indexMinArraySumRows = index;
    }
}
Console.WriteLine($"Строка с минимальной суммой - {indexMinArraySumRows+1}");