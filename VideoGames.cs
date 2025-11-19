class VideoGames : Item
{
   
    string genre;
    string publisher;
    int releaseYear;
    string supportedPlatform;

    public VideoGames(string genre, string publisher, int releaseYear, string supportedPlatform,string title) : base(title, 0.0, false)
    { 
        this.genre = genre;
        this.publisher = publisher;
        this.releaseYear = releaseYear;
        this.supportedPlatform = supportedPlatform;
    }

    public override void Download()
    {
        Console.WriteLine("Is downloading...");
    }

    public void PlayGame()
    {
        Console.WriteLine("Playing game...");
    }

    public void CompleteGame()
    {
        Console.WriteLine("Completing game...");
    }
}