public class GoodFactory
{
    private static Random rnd = new Random();

    public static AGood CreateRandomGoods(int id)
    {
        int type = rnd.Next(1, 4); // Randomly select a type of good (1: FreshFood, 2: FriedFood, 3: FrozenFood)
        switch (type)
        {
            case 1:
                return new FreshFood(id, $"FreshFood_{id}", rnd.NextDouble() * 100, DateTime.Now.AddDays(rnd.Next(1, 10)));
            case 2:
                return new FriedFood(id, $"FriedFood_{id}", DateTime.Now.AddDays(rnd.Next(1, 30)), rnd.NextDouble() * 100);
            case 3:
                return new FrozenFood(id, $"FrozenFood_{id}", rnd.NextDouble() * 100, rnd.Next(-20, -5));
            default:
                throw new ArgumentException("LOẠI HÀNG HÓA KHÔNG HỢP LỆ");
        }
    }
}