using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_задача_3
{

    class Program
    {
        public static double Readdouble()
        //ввод числа для красивых лаб
        {
            bool check = false;
            double doubleNum;
            do
            {
                // Попытка перевести строку в число
                check = Double.TryParse(Console.ReadLine(), out doubleNum);
                // Если попытка неудачная:
                if (!check)
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
            } while (!check);
            // Если попытка удачная:
            return doubleNum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки, чтобы проверить входит ли она в заданный промежуток");
            double x, y;
            x = Readdouble();
            y = Readdouble();
            if (Math.Abs(x) + Math.Abs(y) <= 1)
                Console.WriteLine("Точка входит в промежуток");
            else Console.WriteLine("Точка не входит в промежуток");

        }
    }
}