using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024
{
    public class Task3 : ITaskable
    {
        public void Run()
        {
            Console.WriteLine("Task3\n");

            ConsoleColor originalColor = Console.ForegroundColor; 

            int arrSize = 0 + 4;

            int[] X = new int[arrSize];

            for (int i = 0; i < X.Length; i++)
            {
                Console.Write($"Enter int element X[{i}]: ");

                while (!int.TryParse(Console.ReadLine(), out X[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please enter a valid int element X[{i}]: ");
                    Console.ForegroundColor = originalColor; 
                    Console.Write($"Enter int element X[{i}]: ");
                }
            }

            int max = X[0];
            int min = X[0];

            for (int i = 0; i < arrSize; i++)
            {
                if (X[i] > max)
                {
                    max = X[i];
                }

                if (X[i] < min)
                {
                    min = X[i];
                }

            }


            Console.Write($"\nMax element in arr {max}, min {min}");


        }
    }

}
