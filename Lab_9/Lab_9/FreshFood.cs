public class FreshFood : AGood
{
    public DateTime bestUsedBefore;

    public FreshFood(float id, string name, double price, DateTime bestUsedBefore) : base(id, name, price)
    {
        this.bestUsedBefore = bestUsedBefore;
    }

    public override double CalPrice(int quantity)
    {
        return price * quantity;
    }

    public override string ToString()
    {
        return $"ID: {id}, FreshFood: {name}, Price: {price}, Best Used Before: {bestUsedBefore:dd/MM/yyyy}";
    }


}