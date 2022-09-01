// Написать программу, которая обменивает элементы первой строки и последней строки

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
        matr [i,j] = new Random().Next (-9,10);
    }
    
}
}

void ObnlArray (int [,] matr)
{
    int i = 0; 
    int m = matr.GetLength(0) - 1;
    int temp;
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {   
        temp = matr [i,j];
        matr [i,j] = matr [m,j];
        matr [m,j] = temp;
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
ObnlArray (matrix);
PrintArray (matrix);