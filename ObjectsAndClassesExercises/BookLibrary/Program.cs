using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace BookLibrary
{
    public class Book {
        public String title, author, publisher, isbn;
        public float price;
        public DateTime releaseDate;
    }
    public class Library {
        public string name;
        public List<Book> books = new List<Book>();
    }
    public class Program
    {
       public static void Main(string[] args)
        {
            Library library = new Library();
            int n = int.Parse(Console.ReadLine());
            String[] input;
            
            CultureInfo provider = CultureInfo.InvariantCulture;
            String formatDate = "dd.mm.yyyy";
            
           // add books
            for (int i = 0; i < n; i++)
            {
                Book newBook = new Book();
                input = Console.ReadLine().Split();
                newBook.title = input[0];
                newBook.author = input[1];
                newBook.publisher = input[2];
                newBook.releaseDate = DateTime.ParseExact(input[3], formatDate, provider);
                newBook.isbn = input[4];
                newBook.price = float.Parse(input[5]);

                
                library.books.Add(newBook);
            }

            Dictionary<String, float> authorSum = new Dictionary<String, float>();           

           // get total price by author
            for (int i = 0; i < n; i++)
            {
                if (!authorSum.ContainsKey(library.books[i].author)) {
                    authorSum.Add(library.books[i].author, library.books[i].price);}
                    else {authorSum[library.books[i].author] += library.books[i].price;}
                }

            authorSum = authorSum
                .OrderByDescending(a => a.Value)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

           // print books
            foreach (var item in authorSum)
	        {
		        Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);
	        }
            }           
        }
    }
