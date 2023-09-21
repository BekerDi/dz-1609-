using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace dz16._09_3_
{
    internal class Program
    {
        struct Data 
        {
            public string Name;
            public string City;
            public int Pincode;

        }

        struct Student 
        {
            public string LastName;
            public string Name;
            public int ID;
            public DateTime DateBirth;
            public char Class;
            public double AlcConsum;
        }

        static void Main(string[] args)

        {
            Console.WriteLine("Задание 1");

            Console.WriteLine("Тип данных - максимальное значение - минимальное значение");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"byte -  { byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MinValue} - {byte.MinValue}"); 
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}"); 
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {ulong.MinValue}"); 
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"char - {char.MaxValue} - {char.MinValue}");
            Console.WriteLine($"bool - {bool.TrueString} - {bool.FalseString}");
            Console.WriteLine($"string - не имеет максимального и минимального значений");
            Console.WriteLine($"object - не имеет максимального и минимального значений");

            Console.WriteLine("Задание 2");

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите текст"); 
            string text = Console.ReadLine();
            string zamena = "";
            foreach (char i in text)
            {
                if (char.IsLower(i))
                {
                    zamena += char.ToUpper(i);
                }
                else if (char.IsUpper(i))
                {
                    zamena += char.ToLower(i);

                }
                else { zamena += i; }
            }
            Console.WriteLine("Результат: " + zamena);

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введте свое имя, город и пин-код");
            Data user = new Data();
            user.Name = Console.ReadLine();
            user.City = Console.ReadLine();
            user.Pincode = int.Parse( Console.ReadLine() );
            Console.WriteLine("Информация о пользователе"); 
            Console.WriteLine("Имя:" + user.Name );
            Console.WriteLine("Город: " + user.City);
            Console.WriteLine("PIN-код: " + user.Pincode);

            Console.WriteLine("Задание 4 ");

            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку"); 
            string substring = Console.ReadLine();
            int count = 0;
            int index = 0;
            while((index = str.IndexOf(substring, index)) != -1) 
            {
                count += 1;
                index += substring.Length;
            }
            Console.WriteLine("Количество вхождений " + count);
            
           
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите стандартную цену");
            float normPrise = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите размер скидки"); 
            int discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            int holiday = Convert.ToInt32(Console.ReadLine());
            double savingMoney = ((normPrise * discount) / 100);
            double numBootles = (holiday / savingMoney); 
            Console.WriteLine("Количество бутылок: " + numBootles );

            Console.WriteLine("Задание 6");
            Console.WriteLine("Привет! Как тебя зовут?"); 
            string username = Console.ReadLine();
            Console.WriteLine("Привет, " + username + "!");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000); 
            Random rn = new Random();
            int c = rn.Next(0, 16);
            Console.BackgroundColor = (ConsoleColor)c;
            Console.WriteLine("Но могу показать!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите 12 цифр");
            string barcode = Console.ReadLine();

            if (barcode.Length != 12)
            {
                Console.WriteLine("Некорректная длина штрихкода. Введите 12 цифр.");
                return;
            }

            int sum = 0;
            for (int i = 0; i < barcode.Length; i++)
            {
                int digit = int.Parse(barcode[i].ToString());
                if (i % 2 == 0)
                {
                    sum += digit;
                }
                else
                {
                    sum += digit * 3;
                }
            }

            int checkDigit = (10 - (sum % 10)) % 10;

            Console.WriteLine("Контрольная цифра штрихкода: " + checkDigit);



            Console.WriteLine("Задание 8");
            Student student1 = new Student();
            student1.LastName = "Иванов";
            student1.Name = "Андрей";
            student1.ID = 1;
            student1.Class = 'a';
            student1.AlcConsum = 15;
            Student student2 = new Student();


            student2.LastName = "Красников";
            student2.Name = "Герман";
            student2.ID = 2;
            student2.Class = 'b';
            student2.AlcConsum = 11;
            Student student3 = new Student();

            student3.LastName = "Горх";
            student3.Name = "Алексей";
            student3.ID = 3;
            student3.Class = 'a';
            student3.AlcConsum = 9;
            Student student4 = new Student();

            student4.LastName = "Костюков";
            student4.Name = "Денис";
            student4.ID = 4;
            student4.Class = 'с';
            student4.AlcConsum = 3;
            Student student5 = new Student();

            student5.LastName = "Горохов";
            student5.Name = "Александр";
            student5.ID = 5;
            student5.Class = 'd';
            student5.AlcConsum = 0;

            double allAlc = student1.AlcConsum + student2.AlcConsum + student3.AlcConsum + student4.AlcConsum + student5.AlcConsum;
            double perst1 = (student1.AlcConsum / allAlc) * 100;
            double perst2 = (student2.AlcConsum / allAlc) * 100;
            double perst3 = (student3.AlcConsum / allAlc) * 100;
            double perst4 = (student4.AlcConsum / allAlc) * 100;
            double perst5 = (student5.AlcConsum / allAlc) * 100;
            Console.WriteLine("Общее количество выпитого алкоголя:" + allAlc); 
            Console.WriteLine("Процент алкоголя выпитого 1 студентом: " +  perst1);
            Console.WriteLine("Процент алкоголя выпитого 1 студентом: " + perst2);
            Console.WriteLine("Процент алкоголя выпитого 1 студентом: " + perst2);
            Console.WriteLine("Процент алкоголя выпиогго 1 студентом: " + perst2);
            Console.WriteLine("Процент алкоголя выпитого 1 студентом: " + perst2);





            Console.ReadKey();
        }
    }
    

            





        }
    

