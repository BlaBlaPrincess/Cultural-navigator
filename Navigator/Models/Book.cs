using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title="Название не указано", string author="Автор не указан")
        {
            Title = title;
            Author = author;
        }
    }
}
