using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        List<IVector> listVectors = new List<IVector>();
        List<IVector> listPartners = new List<IVector>(); 

        Random r = new Random();

        for (int i = 0; i < 5; i++)
        {
            if (r.Next(2) == 0)
            {
                listVectors.Add(new Vector2D(r.Next(1, 10), r.Next(1, 10)));
                listPartners.Add(new Vector2D(r.Next(1, 10), r.Next(1, 10)));
            }
            else
            {
                listVectors.Add(new Vector3D(r.Next(1, 10), r.Next(1, 10), r.Next(1, 10)));
                listPartners.Add(new Vector3D(r.Next(1, 10), r.Next(1, 10), r.Next(1, 10)));
            }
        }

        Console.WriteLine("====== Kết quả phép toán trên các cặp vector ======");

        for (int i = 0; i < listVectors.Count; i++)
        {
            IVector v1 = listVectors[i];
            IVector v2 = listPartners[i];

            Console.WriteLine($"======= Cặp vector số {i + 1} =======");
            Console.WriteLine($"V1: {v1} (Module: {v1.Module():F2})");
            Console.WriteLine($"V2: {v2} (Module: {v2.Module():F2})");

            Console.WriteLine($"Cộng: {v1.Add(v2)}");
            Console.WriteLine($"Trừ:  {v1.Subtract(v2)}");
            Console.WriteLine($"Tích vô hướng: {v1.DotProduct(v2)}");

            int ketQuaSoSanh = v1.CompareTo(v2);
            string thongBaoSoSanh;
            if (ketQuaSoSanh > 0)
                thongBaoSoSanh = "V1 lớn hơn V2";
            else if (ketQuaSoSanh < 0)
                thongBaoSoSanh = "V1 bé hơn V2";
            else
                thongBaoSoSanh = "V1 bằng V2";

            Console.WriteLine($"So sánh (IComparable): {thongBaoSoSanh}");

            IVector vClone = (IVector)v1.Clone();
            Console.WriteLine($"Clone V1: {vClone} (Là đối tượng mới: {!ReferenceEquals(v1, vClone)})");
        }
    }
}