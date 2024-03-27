using System;

namespace CSharpLabs2024
{
    internal class Task1
    {
        private static void Is_number_in_range(int num, int start = 1, int end = 14)
        {
            if (num >= start && num <= end)
            {
                Console.WriteLine($"{num} in range");
                return;
            }

            Console.WriteLine($"{num} not in range");
        }

        public static void Run()
        {
            int number1, number2, number3;

            Console.Write("Num 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Num 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Num 3: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write('\n');

            Is_number_in_range(number1);
            Is_number_in_range(number2);
            Is_number_in_range(number3);
        }
    }

    internal class Task2
    {
        private static double GetTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private static double GetTrianglePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        private static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            if (a != b && b != c && a != c)
            {
                return "Scalene";
            }
            return "Isosceles";
        }

        private static double GetTriangleSide(string sideName)
        {
            double side;
            Console.Write($"Side {sideName}: ");
            while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
            {
                Console.WriteLine($"Please enter a valid positive number for side {sideName}:");
                Console.Write($"Side {sideName}: ");
            }
            return side;
        }

        private static bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public static void Run()
        {
            double a, b, c;

            a = GetTriangleSide("a");
            b = GetTriangleSide("b");
            c = GetTriangleSide("c");

            if (IsTriangleValid(a, b, c))
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Triangle is not valid.");
                return;
            }


            Console.WriteLine($"Triangle type: {GetTriangleType(a, b, c)}, Perimeter: {GetTrianglePerimeter(a, b, c)}, Area: {GetTriangleArea(a, b, c)}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Task2.Run();
        }
    }
}
