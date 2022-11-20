using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        public delegate double Сircle(double r);
        static void Main(string[] args)
        {
            /*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
            -       метод получает входным параметром переменную типа double;
            -       метод возвращает значение типа double, которое является результатом вычисления.
            Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
            -       длину окружности по формуле D = 2 * π* R;
            -       площадь круга по формуле S = π* R²;
            -       объем шара. Формула V = 4/3 * π * R³.
            Методы должны быть объявлены как статические.*/
            Console.Write("Введите радиус r=");
            double r = Convert.ToDouble(Console.ReadLine());

            Сircle circle = СircleLen;
            Console.WriteLine($"\nДлину окружности={circle(r):f3}");

            circle += СircleArea;
            Console.WriteLine($"Площадь круга={circle(r):f3}");

            circle += SphereVolume;
            Console.WriteLine($"Объем шара={circle(r):f3}");

            Console.ReadKey();

        }
        public static double СircleLen(double r) => 2 * Math.PI * r; 
        public static double СircleArea(double r) => Math.PI * r * r;
        public static double SphereVolume(double r) => 4.0/3 * Math.PI * r;
    }
       
}
