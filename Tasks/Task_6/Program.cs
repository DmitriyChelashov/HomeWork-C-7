// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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

int SumElements (int [,] matr)
{   int sum = 0;
    int min = 0;
    int minNumber = 0;
     for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {   if (i == 0)
        {sum = sum + matr [i,j];
        min = sum;}
        else sum = sum + matr [i,j];
        if (sum < min)
            {
                min = sum;
                minNumber = i;
            }
        }
        sum = 0;
    }
    return minNumber;
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
Console.WriteLine ("Cтрока с наименьшей суммой элементов:  " + SumElements (matrix));