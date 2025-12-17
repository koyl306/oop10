using System;
using System.Collections.Generic;
using System.Linq;

namespace _10pr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book { Author="автор1", Name="назва1", Title="програмування", Year=2001, Price=95 },
                new Book { Author="автор2", Name="назва2", Title="тайтл2", Year=2002, Price=100 },
                new Book { Author="автор3", Name="назва3", Title="програмування", Year=2003, Price=120 },
                new Book { Author="автор4", Name="назва4", Title="програмування", Year=2004, Price=90 },
                new Book { Author="автор5", Name="назва5", Title="тайтл5", Year=2005, Price=85 },
                new Book { Author="автор6", Name="назва6", Title="тайтл6", Year=2006, Price=70 },
                new Book { Author="автор7", Name="назва7", Title="програмування", Year=2007, Price=60 },
                new Book { Author="автор8", Name="назва8", Title="програмування", Year=2008, Price=80 },
                new Book { Author="автор9", Name="назва9", Title="тайтл8", Year=2009, Price=110 },
                new Book { Author="автор10", Name="назва10", Title="тайтл10", Year=2010, Price=75 }
            };
    
            var programmingBooks = books
                .Where(b => b.Title == "програмування" &&
                            b.Year <= 2006 &&
                            b.Price <= 100)
                .OrderBy(b => b.Author);
    
            Console.WriteLine("Книги з тематики 'Програмування' -");
            foreach (var book in programmingBooks)
            {
                Console.WriteLine($"{book.Author} | {book.Name} | {book.Year} | {book.Price} грн");
            }
    
            var mostExpensiveBook = books
                .OrderByDescending(b => b.Price)
                .First();
    
            Console.WriteLine("\nНайдорожча книга -");
            Console.WriteLine($"{mostExpensiveBook.Author} | {mostExpensiveBook.Name} | {mostExpensiveBook.Price} грн");
        }
    }
}