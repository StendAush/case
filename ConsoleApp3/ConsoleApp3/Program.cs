using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct Parabola
    {
        public double a;
        public double b;
        public double c;

        public Parabola(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void FindRoots()
        {
            // Вычисление дискриминанта
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корни: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                // Один корень (дубликат)
                double x = -b / (2 * a);
                Console.WriteLine($"Корень: x = {x}");
            }
            else
            {
                // Нет действительных корней
                Console.WriteLine("Нет точки пересечения с осью X (дискриминант < 0)");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Задаем заранее прописанные данные
            Parabola[] parabolas = new Parabola[]
            {
            new Parabola(1, -3, 2),   // x^2 - 3x + 2
            new Parabola(1, 2, 1),    // x^2 + 2x + 1
            new Parabola(1, 0, -4),   // x^2 - 4
            new Parabola(1, -2, 5),   // x^2 - 2x + 5 (нет корней)
            new Parabola(2, -8, 6)    // 2x^2 - 8x + 6
            };

            Console.WriteLine("\nРезультаты:");
            for (int i = 0; i < parabolas.Length; i++)
            {
                Console.WriteLine($"Парабола {i + 1} (a={parabolas[i].a}, b={parabolas[i].b}, c={parabolas[i].c}):");
                parabolas[i].FindRoots();
            }
            Console.ReadKey();
        }
    }
}
