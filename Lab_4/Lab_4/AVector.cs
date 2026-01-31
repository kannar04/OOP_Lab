public abstract class AVector
{
    public float x;
    public float y;

    public AVector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public abstract AVector Add(AVector other);     
    public abstract AVector Subtract(AVector other);
    public abstract float DotProduct(AVector other);
    public abstract float Module();                  
}