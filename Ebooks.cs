class Ebooks : Item
{
    string author;
    string language;
    int pages;
    int publication;
    int ISBN;

    public Ebooks(string author, string language, int pages, int publication, int ISBN, string title) : base(title, 0.0, false)
    {
        this.author = author;
        this.language = language;
        this.pages = pages;
        this.publication = publication;
        this.ISBN = ISBN;
    }

    public override void Download()
    {
        Console.WriteLine("Is downloading...");
    }

    public void ViewBook()
    {
        Console.WriteLine("Viewing book...");
    }

    public void ReadBook()
    {
        Console.WriteLine("Reading book...");
    }
}