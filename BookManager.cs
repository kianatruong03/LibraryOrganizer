using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class BookManager
{
    private List<Book> books = new List<Book>();
    private string filePath = "books.txt";

    public BookManager()
    {
        LoadBooks();
    }

    public List<Book> LoadBooks()
    {
        var validBooks = new List<Book>();

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                try
                {
                    var book = ParseBook(line);
                    validBooks.Add(book);
                }
                catch (FormatException ex)
                {
                    // Log or display the error for the invalid book format
                    Console.WriteLine($"Skipping invalid book entry: {ex.Message}");
                }
            }
        }

        books = validBooks;
        return books;
    }


    private Book ParseBook(string line)
    {
        var parts = line.Split(',');

        // Ensure there are exactly 7 parts expected in the file, so that there are no array issues 
        if (parts.Length != 7)
        {
            throw new FormatException($"Invalid book data format: {line}");
        }

        return new Book
        {
            Title = parts[0].Trim(),
            Author = parts[1].Trim(),
            Genre = parts[2].Trim(),
            TotalPages = int.TryParse(parts[3], out int totalPages) ? totalPages : 0,
            PagesRead = int.TryParse(parts[4], out int pagesRead) ? pagesRead : 0,
            InSeries = bool.TryParse(parts[5], out bool inSeries) ? inSeries : false,
            TotalInSeries = int.TryParse(parts[6], out int totalInSeries) ? totalInSeries : 0
        };
    }


    public void AddBook(Book book)
    {
        books.Add(book);
        SaveBooks();
    }

    public void UpdateBook(Book oldBook, Book newBook)
    {
        int index = books.IndexOf(oldBook);
        if (index != -1)
        {
            books[index] = newBook;
            SaveBooks();
        }
    }

    public void DeleteBook(Book book)
    {
        books.Remove(book);
        SaveBooks();
    }

    // This is how the layout of the header tables are suppose to format {getStatus is based off the pages}
    private void SaveBooks()
    {
        var lines = books.Select(book => $"{book.Title},{book.Author},{book.Genre},{book.TotalPages},{book.PagesRead},{book.InSeries},{book.TotalInSeries}");
        File.WriteAllLines(filePath, lines);
    }

}
