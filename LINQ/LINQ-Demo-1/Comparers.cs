namespace LINQ_Demo_1;

public class ProductEqualityComparer : IEqualityComparer<Product>
{
    public bool Equals(Product? x, Product? y)
    => x?.ProductID.Equals(y?.ProductID) ?? y is null;

    public int GetHashCode(Product obj)
    => HashCode.Combine(obj.ProductID);
}