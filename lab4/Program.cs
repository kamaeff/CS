/*
  Напишите консольное приложение на C#, которое конвертирует температуру из градусов Цельсия в градусы Фаренгейта и наоборот. Пользователь должен выбрать тип конвертации и ввести температурное значение.

  Требования:
  1) Создать консольное приложение.
  2) Реализовать функционал для конвертации температуры из градусов Цельсия в градусы Фаренгейта и обратно.
  3) Использовать методы для ввода данных от пользователя и вывода результата.
  4) Обработать возможные ошибки ввода данных.
*/

using System;

class Temperature
{

  static public void Main()
  {
    Console.WriteLine("--------Menu--------");
    Console.WriteLine("1. Celsius to Fahrenheit");
    Console.WriteLine("2. Fahrenheit to Celsius");
    Console.WriteLine("3. Exit");
    Console.WriteLine("---------------------");

    int choice = Convert.ToInt32(Console.ReadLine());

    try
    {
      choice = Convert.ToInt32(Console.ReadLine());

      switch (choice)
      {
        case 1:
          CelsiusToFahrenheit();
          break;
        case 2:
          FahrenheitToCelsius();
          break;
        case 3:
          System.Environment.Exit(1);
          break;
        default:
          Console.WriteLine("Invalid choice");
          break;
      }
    }
    catch (FormatException)
    {
      Console.WriteLine("Invalid choice. Please enter a number.");
    }
  }

  private static void CelsiusToFahrenheit()
  {
    Console.WriteLine("Enter temperature in Celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());

    if (!Check(celsius))
    {
      Console.WriteLine("Invalid temperature");
      return;
    }

    Console.WriteLine((celsius * 9 / 5) + 32);
  }

  private static void FahrenheitToCelsius()
  {
    Console.WriteLine("Enter temperature in Fahrenheit: ");
    double fahrenheit = Convert.ToDouble(Console.ReadLine());

    if (!Check(fahrenheit))
    {
      Console.WriteLine("Invalid temperature");
      return;
    }

    Console.WriteLine((fahrenheit - 32) * 5 / 9);
  }

  private static bool Check(double value)
  {
    return value > 0;
  }
}