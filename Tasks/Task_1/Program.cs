// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

bool FindArray (int [,] matr, int m)
{
    bool c = false;
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {   if (matr [i,j]  == m)
        {Console.WriteLine ($"{i}, {j}");
        c = true;}
    }
    
}
    return c;
   
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
Console.WriteLine ("Введите число для поиска в массиве: ");
int m = int.Parse (Console.ReadLine ());
if (FindArray (matrix, m) == false) Console.WriteLine ("Такого числа неть...");