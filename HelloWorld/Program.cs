using System;

class HelloWorld
{
  public static double x = 0;
  public static double y = 0;
  public static char operation;

  public static string Schet(double x, double y, char opt)
  {
    switch (opt)
    {
      case '+':
        return Convert.ToString(x + y);
      case '-':
        return Convert.ToString(x - y);
      case '*':
        return Convert.ToString(x * y);
      case '/':
        if (y != 0)
        {
          return Convert.ToString(x / y);
        }
        else
        {
          return "Ошибка: деление на ноль!";
        }

      default:
        return "Ты ввел не ту операцию!";
    }
  }

  private static int Main()
  {
    while (true)
    {
      try
      {
        Console.WriteLine("Введи x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введи y: ");

        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выбери операцию (+ - * /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Result: " + Schet(x, y, operation));
        break;
      }
      catch (Exception e)
      {
        Console.WriteLine("Не правильный тип данных!", e.Message);
      }

    }
    return 0;
  }
}