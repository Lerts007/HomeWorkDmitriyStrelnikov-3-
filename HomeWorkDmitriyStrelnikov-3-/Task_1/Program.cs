using System;


class Program
{

    /* Стрельников
     * Задание №1
     * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
     * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
     * в) Добавить диалог с использованием switch демонстрирующий работу класса.
     */
    static void Main(string[] args)
    {
        Complex complex1 = Complex.Enter();

        Complex complex2 = Complex.Enter();
        Console.WriteLine("Какое действие выберите с числами:\n1 - Сложение.\n2 - Вычетание.\n3 - Умнажение.\n");
        int number = int.Parse(Console.ReadLine());
        Complex result;

        switch (number)
        {
            case 1:
                Console.WriteLine("\nСложение.");
                result = complex1.Plus(complex2);
                Console.WriteLine("Результат сложения: {0}", result.ToString());
                break;
            case 2:
                Console.WriteLine("\nВычетание.");
                result = complex1.Minus(complex2);
                Console.WriteLine("\nРезультат вычетания: {0}", result.ToString());
                break;
            case 3:
                Console.WriteLine("\nУмнажение");
                result = complex1.Ymnajenie(complex2);
                Console.WriteLine("\nРезультат умнажение: {0}", result.ToString());
                break;
        }

        Console.ReadLine();

    }


}
class Complex
{
    double im;
    double re;

    public Complex()
    {
        im = 0;
        re = 0;
    }

    public static Complex Enter()
    {
        Console.Write("Введите первое значения комплексного числа: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе значения комплексного числа: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Комплексное число: " + a + "+" + b + "i");

        Complex complex = new Complex(a, b);
        return complex;
    }
    public Complex(double im, double re)
    {
        this.im = im;

        this.re = re;
    }

    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }
    public Complex Minus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im - im;
        x3.re = x2.re - re;
        return x3;
    }
    public Complex Ymnajenie(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im * im - x2.re * re;
        x3.re = re * x2.im + im * x2.re;
        return x3;
    }

    public double Re
    {
        get { return re; }
        set
        {
            if (value >= 0) re = value;
        }
    }
    public string ToString()
    {
        return im + "+" + re + "i";
    }
}
