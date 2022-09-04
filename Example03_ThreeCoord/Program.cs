// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента
int m = 3;
int n = 3;
int p = 3;
int[,,] array = new int[m, n, p];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = new Random().Next(10, 100);
            Console.Write($"Элемент массива с индексом {i} {j} {k}: {array[i, j, k]}  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}