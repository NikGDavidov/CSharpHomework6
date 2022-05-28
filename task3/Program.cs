
// Напишите программу, которая будет создавать копию заданного 2-мерного массива с помощью поэлементного копирования.
int[,] CopyArray(int[,] array)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);

    int[,] result = new int[xSize, ySize];
    for (int i = 0; i < xSize; i++)
    {
        for (int j = 0; j < ySize; j++)
        {
            result[i, j] = array[i, j];
        }
    }
    return result;
}
int[,] Get2DimentionArray(int xSize, int ySize, int from, int to)
{
    int[,] result = new int[xSize, ySize];
    for (int i = 0; i < xSize; i++)
    {
        for (int j = 0; j < ySize; j++)
        {
            result[i, j] = new Random().Next(from, to);
        }
    }
    return result;
}
void Print2DimentionArray(int[,]array)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
for (int i = 0; i < xSize; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < ySize; j++)
        {
           Console.Write(array[i,j] + " ");
        }
    }
    Console.WriteLine();
}
int[,]array = Get2DimentionArray(4,6,0,10);
int[,]copyArray = CopyArray(array);
Print2DimentionArray(array);
Print2DimentionArray(copyArray);
