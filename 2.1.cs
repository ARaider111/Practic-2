using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] numbers = new int [100];
    int n = 297;
    for (int i = 0; i < numbers.Length; ++i)
    {
      numbers[i] = n;
      n -= 3;
    }

    for (int i = 0; i < numbers.Length; ++i)
    {
      Console.WriteLine(numbers[i]);
    }
  }
}