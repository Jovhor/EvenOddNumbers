using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Even Numbers \n");

            Console.WriteLine("Приложение для определения четности числа");

            for (; ; )
            {
                Console.WriteLine("Введите число:");
                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber % 2 == 0)
                    {
                        Console.WriteLine("Четное");
                    }
                else
                {
                    Console.WriteLine("Нечетное");
                }
            }
        }
    }
}
