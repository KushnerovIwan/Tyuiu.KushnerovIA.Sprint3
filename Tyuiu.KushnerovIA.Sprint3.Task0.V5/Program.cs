using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint3.Task0.Lib;

namespace Tyuiu.KushnerovIA.Sprint3.Task0
{
    class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил:  Кушнеров И. А.| ПКТБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант 5                                                               *");
            Console.WriteLine("* Выполнил: Кушнеров Иван Антонович | ПКТБ-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по  *");
            Console.WriteLine("* по формуле.                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int startValue = 1;
            int stopValue = 10;


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(startValue, stopValue);
            Console.WriteLine("Сумма ряда = " + result);
            Console.ReadKey();
        }
    }
}