using System;

public class Vector3D : IVector
{
    public float x;
    public float y;
    public float z;

    public Vector3D(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public float Module()
    {
        return (float)Math.Sqrt(x * x + y * y + z * z);
    }

    public IVector Add(IVector other)
    {
        Vector3D v = (Vector3D)other;
        return new Vector3D(this.x + v.x, this.y + v.y, this.z + v.z);
    }

    public IVector Subtract(IVector other)
    {
        Vector3D v = (Vector3D)other;
        return new Vector3D(this.x - v.x, this.y - v.y, this.z - v.z);
    }

    public float DotProduct(IVector other)
    {
        Vector3D v = (Vector3D)other;
        return (this.x * v.x) + (this.y * v.y) + (this.z * v.z);
    }

    public object Clone()
    {
        return new Vector3D(this.x, this.y, this.z);
    }

    public int CompareTo(object obj)
    {
        IVector other = (IVector)obj;
        return this.Module().CompareTo(other.Module());
    }

    public override string ToString()
    {
        return $"Vector3D({x}, {y}, {z})";
    }
}