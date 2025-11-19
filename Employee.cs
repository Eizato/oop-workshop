class Employee : Users

{
    public Employee (string name, int age) : base(name, age) {}
    public void AddItem ()
    {
        Console.WriteLine("Adding Item...");
        
    }
    public void RemoveItem ()
    {
     Console.WriteLine("Removing Item...");   
    }
}