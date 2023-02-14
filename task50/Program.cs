// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10,100); 
           Console.Write($"{matrix[i,j]}\t");
                   }
                   Console.WriteLine();
    }
}

int SearchElementToMatrix(int[,] matrix, int a, int b)
{
if (matrix.GetLength(0) > a && matrix.GetLength(1) > b && a >= 0 && b >= 0)
return matrix[a-1, b-1];
return 0;
}
  
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = SearchElementToMatrix(matrix, a , b);
if (result != 0)
Console.WriteLine(result);
else
Console.WriteLine("Такого элемента не существует");