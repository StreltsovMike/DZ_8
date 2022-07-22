// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// В задаче не указано чтобы числа были рандомными. Заполним массив числами с шагом +2,
// а если четные числа закончатся, перейдем на нечетные. 

int length=2, 
    width=10, 
    height = 4;
int[,,] array = new int[length,width,height];                 //Зададим массив с рандомными числами
int arrayNumber = 8;

for (int i = 0; i < length; i++)
    for (int j = 0; j < width; j++)
        for (int h = 0; h < height; h++)
        {
            arrayNumber+= 2;
            if(arrayNumber>99)          
            {
                arrayNumber=11;
            }
            array[i, j, h] = arrayNumber;
            System.Console.WriteLine($"{array[i,j,h]}({i},{j},{h})");
        }

