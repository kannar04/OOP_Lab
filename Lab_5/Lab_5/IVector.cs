public interface IVector : ICloneable, IComparable
{
    float Module();
    IVector Add(IVector other);
    IVector Subtract(IVector other);
    float DotProduct(IVector other);
}