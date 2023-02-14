// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)     
         //matrix[0, j]=sum+(matrix[i, j])/matrix.GetLength(0);
        
        {
             sum+=(matrix[i, j]);
    }
    double S=sum / matrix.GetLength(0);
    Console.WriteLine($"Результат ср. ариф. {j + 1} = {Math.Round(S, 2)}");
   //Console.WriteLine($"Результат: {Math.Round(S, 2)}");
 
   }
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
ReleaseMatrix(matrix);

