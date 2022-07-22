

int n = 6;
int m = 6;
int[,] array = new int[n, m];

int row = 0;
int column = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = m;

for (int i = 0; i < array.Length; i++)
{
    array[row, column] = i + 1;
    if (--visits == 0)
    {
        visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }

    column += dx;
    row += dy;
}

for (int i = 0; i < n; i++)                           
{
    for (int j = 0; j < m; j++)
        Console.Write(String.Format("{0,4}", array[i, j]));
    Console.WriteLine();
}
