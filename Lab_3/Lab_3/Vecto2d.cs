class Vecto2d
{
    public float x { get; set; } 
    public float y { get; set;}

    public Vecto2d()
    {
        x = 1f;
        y = 1f;
    }
    public Vecto2d(float _x, float _y)
    {
        x = _x;
        y = _y;
    }
    public Vecto2d(Vecto2d origin)
    {
        x = origin.x;
        y = origin.y;
    }

    public Vecto2d Cong(params Vecto2d[] vecto)
    {
        float sumX = this.x;
        float sumY = this.y;

        foreach (var v in vecto)
        {
            sumX += v.x;
            sumY += v.y;
        }

        return new Vecto2d(sumX, sumY);
    }

    public Vecto2d Nhan(float k)
    {
        return new Vecto2d(this.x * k, this.y * k);
    }

    public float Nhan(Vecto2d origin)
    {
        return (this.x * origin.x) + (this.y * origin.y);
    }

    public float Modun()
    {
        return (float)Math.Sqrt(x * x + y * y);
    }

    public bool CungPhuong(Vecto2d other)
    {
        return Math.Abs(this.x * other.x - this.y * other.y) < 0.001;
    }

    public bool CungHuong(Vecto2d other)
    {
        if (!CungPhuong(other)) return false;

        float tichVoHuong = this.Nhan(other);
        return tichVoHuong > 0;
    }

    public bool VuongGoc(Vecto2d other)
    {
        return Math.Abs(this.Nhan(other)) < 0.0001;
    }

    public void TinhTien(float dx, float dy)
    {
        this.x += dx;
        this.y += dy;
    }

    public override string ToString()
    {
        return $"({x},{y})";
    } 
}