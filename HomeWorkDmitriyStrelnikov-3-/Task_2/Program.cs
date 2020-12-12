using System;

namespace Task_2
{
    class Task_2
    {
        public static void Main(string[] args)
        {
            /* Стрельников.
             *  Задание №2
             *  С клавиатуры вводятся числа, пока не будет введён 0 (каждое 
             *  число в новой строке). Требуется подсчитать сумму всех нечётных 
             *  положительных чисел. Сами числа и сумму вывести на экран, 
             *  используя tryParse.
             *  
             *  P.S. Если рас комментировать строку 27 и за комментировать строки 28, 29. То получится ручной ввод.
             */



            Console.WriteLine("Введите целые отрицательные или положительные числа:");
            int number;
            int sum = 0;
            Random r = new Random();
            do
            {
                //int.TryParse(Console.ReadLine(), out number);
                number = r.Next(-10, 11);
                Console.WriteLine(number);
                if (number > 0 && (number % 2 != 0))
                {
                    sum += number;
                }

            } while (number != 0);
            Console.WriteLine($"Сумма нечетных положительных чисел ровна: {sum}");
            Console.ReadLine();
        }
    }
}
