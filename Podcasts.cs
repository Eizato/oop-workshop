class Podcasts : Item
{
    string releaseYear;
    string hosts;
    string guests;
    int episodeNumber;
    int language;

    public Podcasts(string releaseYear, string hosts, string guests, int episodeNumber, int language, string title) : base(title, 0.0, false)
    {
        this.releaseYear = releaseYear;
        this.hosts = hosts;
        this.guests = guests;
        this.episodeNumber = episodeNumber;
        this.language = language;
    }

    public override void Download()
    {
        Console.WriteLine("Is downloading...");
    }

    public void ListenToPodcast()
    {
        Console.WriteLine("Listning to Podcasts");
    }
    public void CompletePodcast()
    {
        Console.WriteLine("Completing Podcast");
    }
}