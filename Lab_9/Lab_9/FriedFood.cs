public class FriedFood : AGood
{
    public DateTime expiredDate;

    public FriedFood(int id, string name, DateTime expiredDate, double price) : base(id, name, price)
    {
        this.expiredDate = expiredDate;
    }

    public override double CalPrice(int quantity)
    {
        return price * quantity;
    }

    public override string ToString()
    {
        return $"ID: {id}, FriedFood: {name}, Price: {price}, Expired Date: {expiredDate:dd/MM/yyyy}";
    }   
}