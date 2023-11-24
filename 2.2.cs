using System;

class Program {
  public static void Main (string[] args) 
  {
    int n = 0;
    Console.Write("Введите количество чисел в массиве: ");
    n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int [n];

    int k = 1;
    for (int i = 0; i < n; ++i)
    {
      numbers[i] = k;
      k += 2;
    }

    for (int i = 0; i < n; ++i)
    {
      Console.WriteLine(numbers[i]);
    }
  }
}