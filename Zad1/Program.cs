﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            char[] arr;
            arr = str.ToCharArray();

            Console.WriteLine("Результат: ");

            if (arr.Length % 2 != 0)
            {
                Console.Write(str.Reverse().ToArray());
                Console.WriteLine(str);
            }

            else
            {
                string str1 = str.Substring(0, str.Length / 2);
                string str2 = str.Substring(str.Length / 2, str.Length / 2);

                Console.Write(str1.Reverse().ToArray());
                Console.WriteLine(str2.Reverse().ToArray());
            }
        }
    }
}
