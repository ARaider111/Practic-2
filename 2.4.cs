using System;

class Program 
{
  public static void Main (string[] args)
  {
    int [,]temperature = new int[12, 30];
    Random rand = new Random();
    for (int month = 0; month < temperature.GetLength(0); ++month)
    {
      for (int day = 0; day < temperature.GetLength(1); ++day)
      {
        if (month < 2 || month == 11)
        {
          temperature[month, day] = rand.Next(-20, -5);
        } 
        else if (month > 1 && month < 5)
        {
          temperature[month, day] = rand.Next(-5, 15);
        } 
        else if (month > 4 && month < 8)
        {
          temperature[month, day] = rand.Next(15, 25);
        } 
        else if (month > 7 && month < 11)
        {
          temperature[month, day] = rand.Next(0, 15);
        } 
      }
    }

    Console.WriteLine("Матрица средних температур за год: ");
    for (int month = 0; month < temperature.GetLength(0); ++month)
    {
      for (int day = 0; day < temperature.GetLength(1); ++day)
      {
        Console.Write($"{temperature[month, day], -5}");
      }
      Console.WriteLine();
    }
    
    int[] averageTemperatures = new int [12];
    for (int month = 0; month < temperature.GetLength(0); ++month)
    {
      int average = 0, sum = 0;
      for (int day = 0; day < temperature.GetLength(1); ++day)
      {
        sum +=  temperature[month, day];
      }
      average = sum / temperature.GetLength(1);
      averageTemperatures[month] = average;
    }

    for (int i = 0; i < averageTemperatures.Length; i++)
    {
      
        for (int j = 0; j < averageTemperatures.Length - i - 1; j++)
        {
            if (averageTemperatures[j] > averageTemperatures[j + 1])
            {
                int temp = averageTemperatures[j];
                averageTemperatures[j] = averageTemperatures[j + 1];
                averageTemperatures[j + 1] = temp;
            }
        }
     }
    Console.WriteLine("Отсортированный массив средних темпаратур за каждый месяц: ");
    for (int month = 0; month <  averageTemperatures.Length; ++month)
    {
      Console.Write(averageTemperatures[month] + " ");
    }
  }
}

