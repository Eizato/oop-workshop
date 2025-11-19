class Admin : Users 


{
    public Admin (string name, int age) : base (name, age ) {}
    public void ViewInfo ()
    {
     Console.WriteLine("Viewing Item...");   
    }
    public void CreateInfo ()
    {
        Console.WriteLine("Creating Information...");
    }
    public void DeleteInfo ()
    {
        Console.WriteLine("Deleting Information");
    }
    public void Updateinfo ()
    {
        Console.WriteLine("Udating Information...");
    }
}