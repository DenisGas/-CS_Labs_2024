using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024.Task1
{
     internal class Task
    {
        public static void Run()
        {
            Console.WriteLine("Task1");

            Book book = new Book("C# Programming");
            book.Author = new Author { Name = "Sasha Molodetc" };
            book.Content = new Content { Text = "This is text about Sasha" };

            book.Show();

        }
    }
}
