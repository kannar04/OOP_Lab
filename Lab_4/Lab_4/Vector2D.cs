using System;

public class Vector2D : AVector
{
    public Vector2D(float x, float y) : base(x, y)
    {
    }

    public override float Module()
    {
        return (float)Math.Sqrt(x * x + y * y);
    }

    public override AVector Add(AVector other)
    {
        return new Vector2D(this.x + other.x, this.y + other.y);
    }

    public override AVector Subtract(AVector other)
    {
        return new Vector2D(this.x - other.x, this.y - other.y);
    }

    public override float DotProduct(AVector other)
    {
        return (this.x * other.x) + (this.y * other.y);
    }
    
    public override string ToString()
    {
        return $"Vector2D({x}, {y})";
    }
}