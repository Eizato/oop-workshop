class Borrower : Users 

{
    public Borrower (string name, int age) : base (name, age) {}
    public void SelectDetail ()
    {
        Console.WriteLine("Selecting details");
    }
    public void previewdetail()
    {
        Console.WriteLine("Previewing details");
    }

    public void BorrowItem (Item item)
    {
        item.Borrow();
        Console.WriteLine($"{item} is now borrowed.");
    }

}