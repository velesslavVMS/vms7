// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

void PrintArray(double[,] matr)    
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} \t");
}
Console.WriteLine();
}
}
void FillArray(double[,] matr)   
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{


matr[i,j] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2); 
}
}
}

Console.Write("Задайте число строк m = ");
    int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов n = ");
    int n = Convert.ToInt32(Console.ReadLine());
double[,] matri = new double[m, n];
PrintArray(matri);
FillArray(matri);
Console.WriteLine();
PrintArray(matri);

