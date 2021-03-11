using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double result = 0;
                
                ICalculator calculator = new Calculator();
                
                Console.Write("Введите первое число: ");
                double a = calculator.ReadNumber();
                
                Console.Write("Введите второе число: ");
                double b = calculator.ReadNumber();
                
                Console.Write("Выберите операцию '+', '-', '*', '/': ");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = calculator.Sum(a, b);
                        break;

                    case "-":
                        result = calculator.Subtraction(a, b);
                        break;

                    case "*":
                        result = calculator.Multiplication(a, b);
                        break;

                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Деление на ноль недопустимо");
                        }
                        else
                        {
                            result = calculator.Division(a, b);
                        }
                        break;

                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }

                calculator.DisplayResult(result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод числа");
            }
            
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком большое");
            }
            
            catch (Exception)
            {
                Console.WriteLine("Неизвестная ошибка");
            }
            
            finally
            {
                Console.WriteLine("\nНажмите любую клавишу . . .");
                Console.ReadKey(true);
            }
        }
    }
}
