using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//В приложении объявить тип делегата, который ссылается на метод. 
//Требования к сигнатуре метода следующие:
//-метод получает входным параметром переменную типа double;
//-метод возвращает значение типа double, которое является результатом вычисления. 

//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//-длину окружности по формуле D = 2 * π* R;
//-площадь круга по формуле S = π* R²;
//-объем шара.Формула V = 4 / 3 * π * R³.

//Методы должны быть объявлены как статические.

namespace ITMO_BIM_m1_lab20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса:");
            double R=0;
            try
            {
                R = Convert.ToDouble(Console.ReadLine());
                if (R > 0)
                {
                    CalcDlgt CD;
                    CD = CircleLength;
                    //CD += CircleSquare;
                    //CD += SphereVolume;
                    Console.WriteLine($"Длина дуги = {CD(R):0.00}");
                    CD = CircleSquare;
                    Console.WriteLine($"Площадь окружности = {CD(R):0.00}");
                    CD = SphereVolume;
                    Console.WriteLine($"Объем шара = {CD(R):0.00}");
                }
                else
                    Console.WriteLine("Ошибка: введено некорректное число!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: Некорректный ввод!");
            }
            Console.ReadKey();
        }

        static double CircleLength(double r) => 2 * Math.PI * r;

        static double CircleSquare(double r) => Math.PI * Math.Pow(r, 2);

        static double SphereVolume(double r) => 4 / 3 * Math.PI * Math.Pow(r, 3);

        delegate double CalcDlgt(double r);
    }    
}
