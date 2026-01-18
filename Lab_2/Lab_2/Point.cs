class Point
{
    public float x;
    public float y;

    public Point()
    {
        x = 10.0f;
        y = 20.0f;
    }

    public Point(float _x, float _y)
    {
        x = _x;
        y = _y;
    }

    public Point(Point origin)
    {
        x = origin.x;
        y = origin.y;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Tọa độ của điểm: ({x}, {y})");
    }

    public void DistanceBetween2Points(Point SecondPoint)
    {
        double distance = Math.Sqrt(Math.Pow(SecondPoint.x - x, 2) + Math.Pow(SecondPoint.y - y, 2));
        Console.WriteLine($"Khoảng cách giữa 2 điểm ({x}, {y}) và ({SecondPoint.x}, {SecondPoint.y}) là: {distance}");
    }

    public void CheckPointsPosition(Point point)
    {
        if (point.x > 0 && point.y > 0)
        {
            Console.WriteLine("Điểm ({0}, {1}) thuộc góc phần tư thứ nhất", point.x, point.y);
        }
        else if (point.x < 0 && point.y > 0)
        {
            Console.WriteLine("Điểm ({0}, {1}) thuộc góc phần tư thứ hai", point.x, point.y);
        }
        else if (point.x < 0 && point.y < 0)
        {
            Console.WriteLine("Điểm ({0}, {1}) thuộc góc phần tư thứ ba", point.x, point.y);
        }
        else if (point.x > 0 && point.y < 0)
        {
            Console.WriteLine("Điểm ({0}, {1}) thuộc góc phần tư thứ tư", point.x, point.y);
        }
    }

    public void CheckSymmetrialPoint(Point point)
    {
        if (x == point.x && y == -point.y)
        {
            Console.WriteLine("Hai điểm đối xứng qua trục hoành");
        }
        else
        {
            Console.WriteLine("Hai điểm ({0}, {1}) và ({2}, {3}) không đối xứng qua trục hoành", x, y, point.x, point.y);
        }
    }

}