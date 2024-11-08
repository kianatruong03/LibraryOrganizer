using LibraryOrganizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private List<Book> books = new List<Book>();
    private string booksFilePath = "books.txt";

    public MainForm()
    {
        InitializeComponent();
        LoadBooks();
    }

    private void LoadBooks()
    {
        books.Clear();
        var content = TextFileHelper.ReadFromFile(booksFilePath);
        if (!string.IsNullOrEmpty(content))
        {
            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length >= 7) // based off the array
                {
                    var book = new Book
                    {
                        Title = parts[0],
                        Author = parts[1],
                        Genre = parts[2],
                        TotalPages = int.Parse(parts[3]),
                        PagesRead = int.Parse(parts[4]),
                        InSeries = bool.Parse(parts[5]),
                        TotalInSeries = int.Parse(parts[6])
                    };
                    books.Add(book);
                }
            }
        }
        FilterBooks();
    }

    private void FilterBooks()
    {
        var filteredBooks = books.AsEnumerable();

        if (!string.IsNullOrEmpty(txtFilterGenre.Text))
        {
            string genreFilter = txtFilterGenre.Text.ToLower();
            filteredBooks = filteredBooks.Where(b => b.Genre.ToLower().Contains(genreFilter));
        }

        if (!string.IsNullOrEmpty(txtFilterAuthor.Text))
        {
            string authorFilter = txtFilterAuthor.Text.ToLower();
            filteredBooks = filteredBooks.Where(b => b.Author.ToLower().Contains(authorFilter));
        }

        if (!string.IsNullOrEmpty(txtFilterTitle.Text))
        {
            string titleFilter = txtFilterTitle.Text.ToLower();
            filteredBooks = filteredBooks.Where(b => b.Title.ToLower().Contains(titleFilter));
        }

        // Map the book list to include the status
        var bookListWithStatus = filteredBooks.Select(b => new
        {
            b.Title,
            b.Author,
            b.Genre,
            Status = b.GetStatus(),
            b.PagesRead,
            b.TotalPages,
            b.InSeries,
            b.TotalInSeries
        }).ToList();

        dataGridViewBooks.DataSource = bookListWithStatus;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        SimpleView simpleView = new SimpleView();
        if (simpleView.ShowDialog() == DialogResult.OK)
        {
            books.Add(simpleView.Book);
            SaveBooks();
            FilterBooks();
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewBooks.SelectedRows.Count > 0)
        {
            var selectedBook = (Book)dataGridViewBooks.SelectedRows[0].DataBoundItem;
            SimpleView simpleView = new SimpleView(selectedBook);
            if (simpleView.ShowDialog() == DialogResult.OK)
            {
                var index = books.IndexOf(selectedBook);
                books[index] = simpleView.Book;
                SaveBooks();
                FilterBooks();
            }
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewBooks.SelectedRows.Count > 0)
        {
            var selectedBook = (Book)dataGridViewBooks.SelectedRows[0].DataBoundItem;
            //We want to prompt the user so that they dont accidently just delete the book
            var confirmResult = MessageBox.Show($"Are you sure you want to delete '{selectedBook.Title}'?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                books.Remove(selectedBook);
                SaveBooks();
                FilterBooks();
            }
        }
    }

    private void SaveBooks()
    {
        var content = string.Join(Environment.NewLine, books.Select(b =>
            $"{b.Title}|{b.Author}|{b.Genre}|{b.TotalPages}|{b.PagesRead}|{b.InSeries}|{b.TotalInSeries}"));
        TextFileHelper.WriteToFile(booksFilePath, content);
    }

    private void txtFilterGenre_TextChanged(object sender, EventArgs e)
    {
        FilterBooks();
    }

    private void txtFilterAuthor_TextChanged(object sender, EventArgs e)
    {
        FilterBooks();
    }

    private void txtFilterTitle_TextChanged(object sender, EventArgs e)
    {
        FilterBooks();
    }
}
