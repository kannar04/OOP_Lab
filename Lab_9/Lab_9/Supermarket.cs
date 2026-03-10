using System.Collections.Generic;

public class Supermarket
{
    private static Supermarket instance;

    public List<AGood> inventory = new List<AGood>();

    private Supermarket()
    {
    }

    public static Supermarket GetInstance()
    {
        if (instance == null)
        {
            instance = new Supermarket();
        }

        return instance;
    }

    public void GenerateRandomInventory(int quantity)
    {
        for (int i = 0; i <= quantity; i++)
        {
            inventory.Add(GoodFactory.CreateRandomGoods(i + 1));
        }
    }
    
    public void DisplayInventory()
    {
        Console.WriteLine("KHO HÀNG TRONG SIÊU THỊ");
        foreach (AGood goods in inventory)
        {
            Console.WriteLine(goods.ToString());
        }
    }

}