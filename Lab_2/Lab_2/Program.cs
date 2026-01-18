using System.Text;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;


        Random rnd = new Random();

        List<Point> points = new List<Point>();
        for (int i = 0; i < 5; i++)
        {
            float x = rnd.Next(-10, 11);
            float y = rnd.Next(-10, 11);
            points.Add(new Point(x, y));
        }

        Console.WriteLine("================== Thông tin các điểm =================");
        foreach (Point point in points)
        {
            point.ShowInfo();
        }

        Console.WriteLine("================== Vị trí (góc phần tử của các điểm =================");
        foreach (Point point in points)
        {
            point.CheckPointsPosition(point);
        }

        Console.WriteLine("================== Khoảng cách giữa các điểm =================");
        foreach (Point point in points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                if (point != points[i])
                {
                    point.DistanceBetween2Points(points[i]);
                }
            }
        }

        Console.WriteLine("================== Kiểm tra đối xứng qua trục hoành =================");
        for (int i = 0; i < points.Count; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                points[i].CheckSymmetrialPoint(points[j]);
            }
        }

        Console.WriteLine("================== Ba điểm tạo thành tam giác =================");
        FindTriangle(points);
    }

    static void FindTriangle(List<Point> points)
    {
        for (int i = 0; i < points.Count - 2; i++)
        {
            for (int j = i + 1; j < points.Count - 1; j++)
            {
                for (int k = j + 1; k < points.Count; k++)
                {
                    Point p1 = points[i];
                    Point p2 = points[j];
                    Point p3 = points[k];

                    double val1 = (p2.x - p1.x) * (p3.y - p2.y);
                    double val2 = (p3.x - p2.x) * (p2.y - p1.y);

                    if (val1 != val2)
                    {
                        Console.WriteLine($"Tìm thấy 3 điểm tạo thành tam giác lần lượt là:");
                        Console.Write("- Điểm 1: "); p1.ShowInfo();
                        Console.Write("- Điểm 2: "); p2.ShowInfo();
                        Console.Write("- Điểm 3: "); p3.ShowInfo();
                        return;
                    }
                }
            }
        }
        Console.WriteLine("Không tìm thấy tam giác nào (Tất cả điểm thẳng hàng).");
    }
}
