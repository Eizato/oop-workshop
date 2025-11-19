public abstract class Item
{
    protected string title; 

    protected double rating; 

    protected bool Isborrowed;

    public Item (string title, double rating, bool Isborrowed)
    {
        this.title = title;
        this.rating = rating;
        this.Isborrowed = Isborrowed;
    }
    public void Borrow() => Isborrowed = true;
    public void Return() => Isborrowed = false;
    public void RateItem(double rating)
    {
        if (Isborrowed == false )
        {
            Console.WriteLine("Only borrowed items can be rated. ") ; 
        }
        this.rating = rating;
    }

    public abstract void Download ();
}