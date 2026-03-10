public abstract class AGood
{
    public float id;
    public string name;
    public double price;

    public AGood(float id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }

    public abstract double CalPrice(int quantity);
    
}
