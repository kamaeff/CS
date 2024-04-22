/*
  Задача: Калькулятор для вычисления площади прямоугольника и круга
  Напишите программу на C#, которая предлагает пользователю выбрать фигуру для вычисления площади: прямоугольник или круг. 
  После выбора фигуры, программа запрашивает необходимые параметры и выводит площадь выбранной фигуры.

  Требования:
  1) Создать консольное приложение.
  2) Реализовать функционал для вычисления площади прямоугольника и круга.
  3) Использовать методы для ввода данных от пользователя и вывода результата.
  4) Обработать возможные ошибки ввода данных.
*/

using System;
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
          bool check = Check(r);
          if (check == false)
          {
            throw new Exception("Radius must be > 0");
          }
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

          bool _check_width = Check(width);
          bool _check_height = Check(height);

          if (_check_width == false || _check_height == false)
          {
            throw new Exception("Width or height must be > 0");
          }

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

  private static bool Check(double value)
  {
    return value > 0;
  }


}