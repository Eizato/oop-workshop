class Apps : Item
{
    double version;
    string publisher;
    string supportedPlatform;
    double fileSize;

    public Apps(double version, string publisher, string supportedPlatform, double fileSize, string name) : base(name, 0.0, false)
    {
        this.version = version;
        this.publisher = publisher;
        this.supportedPlatform = supportedPlatform;
        this.fileSize = fileSize;
    }

    public override void Download()
    {
        Console.WriteLine("Is downloading...");
    }
    public void DisplayApp ()
    {
        Console.WriteLine("Displaying app");
    }
}
