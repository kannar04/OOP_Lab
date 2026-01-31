using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;
        
        List<AVector> listVectors = new List<AVector>(); 
        List<AVector> listPartners = new List<AVector>();

        Random r = new Random();

        for (int i = 0; i < 5; i++)
        {
            if (r.Next(2) == 0)
            {
                listVectors.Add(new Vector2D(r.Next(1, 10), r.Next(1, 10)));
                listPartners.Add(new Vector2D(1, 1));
            }
            else
            {
                listVectors.Add(new Vector3D(r.Next(1, 10), r.Next(1, 10), r.Next(1, 10)));
                listPartners.Add(new Vector3D(1, 1, 1));
            }
        }

        Console.WriteLine("=== Kết quả phép toán trên các vector ===");

        for (int i = 0; i < listVectors.Count; i++)
        {
            AVector v1 = listVectors[i]; 
            AVector v2 = listPartners[i];  

            Console.WriteLine($"Input: {v1.ToString()}");
            Console.WriteLine($"Module: {v1.Module():F2}");

            Console.WriteLine($"Cộng với {v2.ToString()}: {v1.Add(v2).ToString()}");
            Console.WriteLine($"Trừ với {v2.ToString()}: {v1.Subtract(v2).ToString()}");
            Console.WriteLine($"Tích vô hướng với {v2.ToString()}: {v1.DotProduct(v2)}");
        }
    }
}