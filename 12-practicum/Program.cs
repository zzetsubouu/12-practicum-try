﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_practicum
{
    class Program
    {
        //Задача 1. Вычислить значение выражения, определив и использовав дополнительный метод:

        //static void Main(string[] args)
        //{
        //    double y = Func(6) + Func(13) + Func(21);
        //    Console.WriteLine($"y={y}");
        //    Console.ReadKey();
        //}
        //static double Func(int x)
        //{
        //    return (Math.Sqrt(x) + x) / 2;
        //}
        
        
        
        
        
        
        
        
        
        
        
        
        
        //Задача 2. Вычислить значение выражения, определив и использовав дополнительный метод:
        //static void Main(string[] args)
        //{
        //    double y = Func(5, 7) + Func(12, 8) + Func(19, 2);
        //    Console.WriteLine($"y={y}");
        //    Console.ReadKey();
        //}
        //static double Func(int x1, int x2)
        //{
        //    return (Math.Sqrt(x1) + x1) / Math.Sqrt(x2) + x2;
        //}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //Задача 3. Найти максимальную величину из двух целых переменных a, b с использованием вспомогательных методов.
        //static void Main(string[] args)
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Func(a, b));
        //    Console.ReadKey();
        //}
        //static double Func(int a, int b)
        //{
        //    //вариант с тернарной операцией
        //    int result = a>b ? a : b;
        //    return result;
        //    //2 вариант
        //    //return Math.Max(a, b);
        //}
        
        
        
        
        
        
        
        
        
        
        
        
        
        //Задача 4. Найти максимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов. 
        //static void Main(string[] args)
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("c=");
        //    int c = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Func(a, b, c));
        
        //    Console.ReadKey();
        //}
        //static double Func(int a, int b, int c)
        //{
        //    //вариант с тернарной операцией
        //    int result = a>c && a>b ? a : b>c &&b>a? b :c;
        //    return result;
        //    //2 вариант
        //    //return Math.Max(Math.Max(a, b), c);
        //}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //Задача 5. Найти s=max(a, b) + max(c, d), используя вспомогательную функцию (метод).
        
        //вариант с 4 переменными
        //static void Main(string[] args)
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("c=");
        //    int c = int.Parse(Console.ReadLine());
        //    Console.Write("d=");
        //    int d = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"s={Func(a, b, c, d)}");
        
        //    Console.ReadKey();
        //}
        //static double Func(int a, int b, int c, int d)
        //{
        //    int block1 = a>b?a:b;
        //    int block2 = c>d?c:d;
        //    return block1 + block2;
        //    //2 вариант
        //    //return Math.Max(a, b) + Math.Max(c, d);
        //}
        
        //вариант с 2 переменными
        //static void Main(string[] args)
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"sum={Func(a, b) + Func(a, b)}");
        
        //    Console.ReadKey();
        //}
        //static double Func(int a, int b)
        //{
        //    int result = a > b ? a : b;
        //    return result;
        //}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //Задача 6. Вывести дни недели в зависимости от номера дня с использованием вспомогательного метода.
        //static void Main(string[] args)
        //{
        //    Console.Write("введите номер дня недели: ");
        //    int day = int.Parse(Console.ReadLine());
        //    DayOfWeek(day);
        //    Console.ReadKey();
        //}
        //static void DayOfWeek(int dayOfWeek)
        //{
        //    switch (dayOfWeek)
        //    {
        //        case 1: Console.WriteLine("понедельник"); break;
        //        case 2: Console.WriteLine("вторник"); break;
        //        case 3: Console.WriteLine("среда"); break;
        //        case 4: Console.WriteLine("четверг"); break;
        //        case 5: Console.WriteLine("пятница"); break;
        //        case 6: Console.WriteLine("суббота"); break;
        //        case 7: Console.WriteLine("воскресенье"); break;
        //        default: Console.WriteLine("введите номер от 1 до 7"); break;
        //    }
        //}   
    }
}
