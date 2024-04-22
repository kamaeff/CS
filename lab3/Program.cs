﻿using System;
using lab3;

class Figures
{
  public static double r;

  public static double width;
  public static double height;
  static void Main(string[] args)
  {
    Console.WriteLine("------Menu------");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Rectangle");
    Console.WriteLine("----------------");

    switch (Console.ReadLine())
    {
      case "1":
        Console.WriteLine("r= ");
        try
        {
          r = Convert.ToDouble(Console.ReadLine());
          double res = Circle.CircleSquare(r);
          Console.WriteLine("Square of circle = " + res);
        }
        catch (Exception e) { Console.WriteLine(e.Message, "Ошибка ввода"); }
        break;

      case "2":
        try
        {
          Console.WriteLine("Paste width:");
          width = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Paste height:");
          height = Convert.ToDouble(Console.ReadLine());

          double res = Rectangle.RectangleSquare(width, height);
          Console.WriteLine("Square of rectangle = " + res);
        }
        catch (Exception e) { Console.WriteLine(e.Message, "Ошибка ввода"); }

        break;

      default:
        Console.WriteLine("Wrong choice");
        break;
    }
  }


}