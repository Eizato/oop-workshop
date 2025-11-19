class Songs : Item
{
    string composer;
    string singer;
    string genre;
    string fileType;
    int duration;
    string language;

    public Songs(string composer, string singer, string genre, string fileType, int duration, string language, string title) : base(title, 0.0, false)
    {
        this.composer = composer;
        this.singer = singer;
        this.genre = genre;
        this.fileType = fileType;
        this.duration = duration;
        this.language = language;
    }

    public override void Download()
    {
        Console.WriteLine("Is downloading...");
    }
    public void PlaySong()
    {
        Console.WriteLine("Playing sonng...");
    }
     
}