using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float one, two, result;
            char sign;
            Console.WriteLine("Введи первое число, после введи (+,-,*,/) и второе число");
            Console.WriteLine("Введи первое число");
            one = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введи знак действия");
            sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введи второе число");
            two = Convert.ToSingle(Console.ReadLine());
            if (sign == '+')
            {
                result = one + two;
                Console.WriteLine("Сумма ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '-')
            {
                result = one - two;
                Console.WriteLine("Разность ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                result = one * two;
                Console.WriteLine("Произведение ваших чисел равно " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '/')
            {
                if (two == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    result = one / two;
                    Console.WriteLine("Частное ваших чисел равна " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }


            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();


            }
        }
    }
}
