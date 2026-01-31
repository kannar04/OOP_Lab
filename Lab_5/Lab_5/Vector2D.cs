public class Vector2D : IVector
{
    public float x;
    public float y;

    public Vector2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float Module()
    {
        return (float)Math.Sqrt(x * x + y * y);
    }

    public IVector Add(IVector other)
    {
        Vector2D v = (Vector2D)other;
        return new Vector2D(this.x + v.x, this.y + v.y);
    }

    public IVector Subtract(IVector other)
    {
        Vector2D v = (Vector2D)other;
        return new Vector2D(this.x - v.x, this.y - v.y);
    }

    public float DotProduct(IVector other)
    {
        Vector2D v = (Vector2D)other;
        return (this.x * v.x) + (this.y * v.y);
    }

    public object Clone()
    {
        return new Vector2D(this.x, this.y);
    }

    public int CompareTo(object obj)
    {
        IVector other = (IVector)obj;
        return this.Module().CompareTo(other.Module());
    }

    public override string ToString()
    {
        return $"Vector2D({x}, {y})";
    }
}