public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int TotalPages { get; set; }
    public int PagesRead { get; set; }
    public bool InSeries { get; set; }
    public int TotalInSeries { get; set; }

    public string Status => GetStatus();

    // Had to improvise as visuals are tricky so instead tracks if you completed the book
    public string GetStatus()
    {
        if (PagesRead == 0)
            return "Not Started";
        if (PagesRead < TotalPages)
            return "In Progress";
        return "Completed";
    }
}

