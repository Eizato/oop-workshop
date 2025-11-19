class Movies : Item
{
    string director;
    string genre;
    int releaseYear;
    int language;
    double duration;

    public Movies(string director, string genre, int releaseYear,int language, double duration, string title) : base(title, 0.0, false)
    {
        this.director = director;
        this.genre = genre;
        this.releaseYear = releaseYear;
        this.language = language;
        this.duration = duration;
    }

    public override void Download()
    {
        Console.WriteLine("Is downloading...");
    }

    public void WatchMovie()
    {
        Console.WriteLine("Watching movie...");
    }
}