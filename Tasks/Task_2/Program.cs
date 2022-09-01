// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

string ArithmeticMean(int[,] matr)
{
    string result = string.Empty;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + " ";
    }
    return result;
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
Console.WriteLine(ArithmeticMean(matrix));