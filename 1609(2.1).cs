using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace dz16._09_1._2_
{
    internal class Program

    {
        enum BankAccount
        {
            Current,
            Saving

        }
        struct BankAccount1
        {
            public int Number;
            public string Type;
            public double Balance;

        }
        enum University 
        {
            KGU,
            KAI,
            KHTI
        }
        struct Worker
        {
            public string Name;
            public University University; 


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1");
            BankAccount now = BankAccount.Current;
            Console.WriteLine("Тип банковского счета {0} ", now);
            Console.ReadKey();


            Console.WriteLine("Задание 3.2");
            BankAccount1 account;
            account.Number = 35468935;
            account.Type = "Saving";
            account.Balance = 177.7;
            Console.WriteLine("Номер счета: " + account.Number);
            Console.WriteLine("Тип счета: " + account.Type);
            Console.WriteLine("Баланс: " + account.Balance);

            Console.WriteLine("Задание 3.3");

            Worker worker1;
            worker1.Name = "Ленар";
            worker1.University = University.KGU;

            Worker worker2;
            worker2.Name = "Тимур";
            worker2.University = University.KAI;

            Worker worker3;
            worker3.Name = "Юрий";
            worker3.University = University.KHTI;

            Console.WriteLine("Имя " + worker1.Name + ", ВУЗ: " + worker1.University);
            Console.WriteLine("Имя " + worker2.Name + ", ВУЗ: " + worker2.University);
            Console.WriteLine("Имя " + worker3.Name + ", ВУЗ: " + worker3.University);





            Console.ReadKey();




        }
       

    }
}
