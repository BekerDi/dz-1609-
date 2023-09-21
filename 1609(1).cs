using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуй," + name + "!");

            Console.WriteLine("Задание 2.2");
            Console.WriteLine("Введите 2 числа");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            float quotient = Convert.ToSingle(num1) / num2;
            if (num2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя! Введите второе число не равное 0!");
                int num3 = Convert.ToInt32(Console.ReadLine());
                float quotient1 = Convert.ToSingle(num1) / num3;
                Console.WriteLine("Результат деления " + num1 + " на " + num3 + " = " + quotient1);

            }
            else
            {
                Console.WriteLine("Результат деления" + num1 + " на " + num2 + " = " + quotient);
            }

            Console.WriteLine("Задание 2.3");
            bool t = true;
            Console.WriteLine("Введите коэффициенты уравнения");

            while (t)
            {
                try
                {
                    Console.WriteLine("Введите значение коэффициента а");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение коэффициента b");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение коэффициента c");
                    double c = double.Parse(Console.ReadLine());
                    double D = b * b - 4 * a * c;



                    if (D < 0.0)
                    {
                        Console.WriteLine("Нет решения");

                    }
                    else if (D == 0.0)

                    {
                        double sqrtd = Math.Sqrt(D);
                        double x1 = (-b / (2 * a));
                        Console.WriteLine($"Корнем уравнения является {x1}");
                    }
                    else
                    {


                        double sqrtd = Math.Sqrt(D);
                        double x1 = ((-b + sqrtd) / (2 * a));
                        double x2 = ((-b - sqrtd) / (2 * a));

                        Console.WriteLine($"Корнями уравннеия являются {x1}, {x2}");

                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели некорректное значение! Попробуйте еще раз!");
                }
            }
            Console.WriteLine("Задание 2.4");
            Console.WriteLine("Введите букву (английский алфавит)");
            string l = Console.ReadLine();
            char letter = char.Parse(l);
            if (letter < 'z')
            {
                letter++;

                Console.WriteLine("Следующая буква " + letter);
            }
            else
            {
                Console.WriteLine("z - последняя буква алфавита! Попроуйте еще раз!");
                char letter2 = char.Parse(Console.ReadLine());
                letter2++;
                Console.WriteLine("Следующая буква " + letter2);
            }











            Console.ReadKey();
        }
    }
}
