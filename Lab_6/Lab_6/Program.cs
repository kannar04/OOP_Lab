using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;

        List<Vector3d> vectorList = new List<Vector3d>();
        vectorList.Add(new Vector3d(1, 2, 3));
        vectorList.Add(new Vector3d(4, 5, 6));
        vectorList.Add(new Vector3d(7, 8, 9));

        Console.WriteLine("Danh sách các Vector ban đầu");
        foreach(Vector3d v in vectorList)
        {
            Console.WriteLine(v.ToString());
        }

        Console.WriteLine("Test các phép toán");
        Vector3d v1 = vectorList[0];
        Vector3d v2 = vectorList[1];

        // Test toán tử đỏi dấu (1 ngôi)
        Vector3d doiDau = -v1;
        Console.WriteLine($"1. Đổi chiều của vector {v1} là : {doiDau} ");

        // Test toán tử cộng (2 ngôi)
        Vector3d tong = v1 + v2;
        Console.WriteLine($"2. Tổng của {v1} và {v2} là: {tong}");

        // Test toán tử trừ (2 ngôi)
        Vector3d hieu = v1 - v2;
        Console.WriteLine($"3. Hiệu của {v1} và {v2} là {hieu}");

        // Test toán tử ! (tính module)
        float moduleV1 = !v1;
        Console.WriteLine($"4. Module của {v1} là {moduleV1}");

        Console.WriteLine($"Module của {vectorList[2]} là {!vectorList[2]}");
    }
}