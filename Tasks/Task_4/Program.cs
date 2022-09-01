// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void PrintArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write ($"{matr [i, j]} ");
    }
    Console.WriteLine ();
}
}

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr [i,j] = new Random().Next (0,10);
    }
    
}
}

void Ordering(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int m = 0; m < matr.GetLength(1) -j - 1; m++)
            {
                if (matr [i,m] < matr [i, m+1])
                {
                    int temp = matr [i,m];
                    matr [i,m] = matr [i,m+1];
                    matr [i,m+1] = temp;
                }
            }
        }
    }
}

Console.WriteLine ("Введите количество строк в массиве: ");
int n = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите количество столбцов в массиве: ");
int k = int.Parse (Console.ReadLine ());
int [,] matrix = new int [n,k];
Console.WriteLine ();
FillArray (matrix);
PrintArray (matrix);
Console.WriteLine ();
Ordering (matrix);
PrintArray (matrix);