using System;
using System.Collections.Generic;

class Program
{
  public static Dictionary<string, int> CalculateAverageTemperatures(Dictionary<string, int[]> monthTemperatures)
  {
    Dictionary<string, int> averageTemperatures = new Dictionary<string, int>();
    foreach (var month in monthTemperatures)
    {
      int sum = 0;
      foreach (var temperature in month.Value)
      {
        sum += temperature;
      }
      int average = sum / month.Value.Length;
      averageTemperatures.Add(month.Key, average);
    }
    return averageTemperatures;
  }
  
  public static void Main (string[] args)
  {
    Random rand = new Random();
    Dictionary<string, int[]> monthTemperatures = new Dictionary<string, int[]>();
    string[] months = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};

    int k = 0;
    foreach (string month in months)
    {
      ++k;
      int[] temperatures = new int[30];
      for (int i = 0; i < temperatures.Length; ++i)
      {
        if (k < 3 || k == 12)
        {
          temperatures[i] = rand.Next(-20, -5);
        } 
        if (k > 2 && k < 6)
        {
          temperatures[i] = rand.Next(-5, 15);
        } 
        if (k > 5 && k < 9)
        {
          temperatures[i] = rand.Next(15, 25);
        } 
        if (k > 8 && k < 12)
        {
          temperatures[i] = rand.Next(0, 15);
        } 
      }
      monthTemperatures.Add(month, temperatures);
    }

    Console.WriteLine("Средние температуры за дни:" );
    foreach(var month in monthTemperatures)
    {
      Console.Write($"{month.Key}: ");
      foreach(var temp in month.Value)
      {
        Console.Write(temp + " ");
      }
      Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Средние температуры за месяцы:" );
    Dictionary<string, int> averageTemperatures = CalculateAverageTemperatures(monthTemperatures);
    
    foreach (var temperature in averageTemperatures)
    {
      
    }
    
    foreach (var temperature in averageTemperatures)
    {
      Console.WriteLine($"{temperature.Key}: {temperature.Value}");
    }
  }
}
