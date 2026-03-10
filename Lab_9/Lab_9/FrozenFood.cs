public class FrozenFood : AGood
{
    public double maxTemp { get; set; }

    public FrozenFood(int id, string name, double price, double maxTemp) : base(id, name, price)
    {
        this.maxTemp = maxTemp;
    }

    public override double CalPrice(int quantity)
    {
        return price * quantity;
    }
    public override string ToString()
    {
        return $"ID: {id}, FrozenFood: {name}, Price: {price}, Max Temperature: {maxTemp}°C";
    }
}