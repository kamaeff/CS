using System;

class Lab2
{
  public static int x = 0;

  public static int Main()
  {
    while (true)
    {
      try
      {
        Console.WriteLine("Введи число: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result: " + (x > 1 ? (x == 2 || !IsDivisible(x) ? "Простое" : "Не простое") : "Число не должно быть больше 1"));
        break;
      }
      catch (Exception e)
      {
        Console.WriteLine("Не правильный тип данных!", e.Message);
      }
    }
    return 0;
  }

  static bool IsDivisible(int number)
  {
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
      if (number % i == 0)
      {
        return true;
      }
    }
    return false;
  }
}