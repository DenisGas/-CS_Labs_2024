using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024.Task1
{
    internal class Book
    {
        private readonly Title title;
        private Author author;
        private Content content;

        public Book(string bookTitle)
        {
            title = new Title(bookTitle);
        }

        public Author Author
        {
            get { return author; }
            set { author = value; }
        }

        public Content Content
        {
            get { return content; }
            set { content = value; }
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

}
