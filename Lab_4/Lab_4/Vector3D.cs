public class Vector3D: AVector
{
    private float z;

    public Vector3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }
    
    public override float Module()
    {
        return (float)Math.Sqrt(x * x+ y * y + z * z);
    }

    public override AVector Add(AVector other)
    {
        Vector3D v = (Vector3D)other;
        return new Vector3D(this.x + v.x, this.y + v.y, this.z + v.z);
    }

    public override AVector Subtract(AVector other)
    {
        Vector3D v = (Vector3D)other;
        return new Vector3D(this.x - v.x, this.y - v.y, this.z - v.z);
    }

    public override float DotProduct(AVector other)
    {
        Vector3D v = (Vector3D)other;
        return (this.x * v.x) + (this.y * v.y) + (this.z * v.z);
    }

    public override string ToString()
    {
        return $"Vector3D({x}, {y}, {z})";
    }
}