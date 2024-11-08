using System;
using System.Windows.Forms;

public partial class SimpleView : Form
{
    public Book Book { get; private set; }

    public SimpleView()
    {
        InitializeComponent();
    }

    public SimpleView(Book book) : this()
    {
        txtTitle.Text = book.Title;
        txtAuthor.Text = book.Author;
        txtGenre.Text = book.Genre;
        txtPagesRead.Text = book.PagesRead.ToString();
        txtTotalPages.Text = book.TotalPages.ToString();
        chkInSeries.Checked = book.InSeries;
        txtTotalInSeries.Text = book.TotalInSeries.ToString();
    }

    //Layout of saving the book
    private void btnSave_Click(object sender, EventArgs e)
    {
        Book = new Book
        {
            Title = txtTitle.Text,
            Author = txtAuthor.Text,
            Genre = txtGenre.Text,
            //Parses the pages so that you see how many there are in all of them
            PagesRead = int.TryParse(txtPagesRead.Text, out int pagesRead) ? pagesRead : 0,
            TotalPages = int.TryParse(txtTotalPages.Text, out int totalPages) ? totalPages : 0,
            InSeries = chkInSeries.Checked,
            TotalInSeries = int.TryParse(txtTotalInSeries.Text, out int totalInSeries) ? totalInSeries : 0
        };
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
