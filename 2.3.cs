using System;

class Program
{
  public static void Main (string[] args) 
  {
    int n = 0;
    Console.WriteLine ("Введите длину матрицы: ");
    n = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; ++i)
    {
      for (int j = 0; j < n; ++j)
      {
        if (j == 0 || i == 0)
        {
          matrix[i, j] = 1;
        }
        else 
        {
          matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
        }
        Console.Write($"{matrix[i, j], -5}");
      }
      Console.WriteLine();
    }
  }
}
