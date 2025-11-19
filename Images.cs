class Images : Item
{
    int resolution;
    string fileFormat;
    int fileSize;
    DateTime dateTaken;

    public Images(int resolution, string fileFormat, int fileSize, DateTime dateTaken, string title) : base(title, 0.0, false)
    {
        this.resolution = resolution;
        this.fileFormat = fileFormat;
        this.fileSize = fileSize;
        this.dateTaken = dateTaken;
    }

    public override void Download()
    {
        Console.WriteLine("Is downloading...");
    }

    public void DisplayImage()
    {
        Console.WriteLine("Displaying image...");
    }
}