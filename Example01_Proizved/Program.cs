// Найти произведение двух матриц
int m = 2;
int n = 2;
int[,] array = new int[m, n];
int[,] array2 = new int[m, n];
int[,] multimatrix = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(0, 10);
        Console.Write("{0}\t", array2[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < array2.GetLength(0); k++)
        {
            multimatrix[i,j] += array[i,k] * array2[k,j];
        }
    Console.Write("{0}\t", multimatrix[i, j]);
    }
    Console.WriteLine();
}