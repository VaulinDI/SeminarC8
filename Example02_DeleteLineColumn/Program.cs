// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int m = 3;
int n = 3;
int[,] array = new int[m, n];

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

int minElement = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (minElement > array[i, j])
        {
            minElement = array[i, j];
        }
    }
}
Console.WriteLine(minElement);

