namespace clean_architecture_using_mediatR;

public static class InMemoryDB
{
    private static Dictionary<int, Product> _Products = new Dictionary<int, Product>();
    public static IEnumerable<Product> Get_Products()
    {
        return _Products.Values;
    }

    public static void AddProduct(Product product)
    {
        _Products.Add(product.Id, product);
    }

    public static void RemoveProduct(int id)
    {
        _Products.Remove(id);
    }

    public static Product? GetProduct(int id)
    {
        return _Products.TryGetValue(id, out var product) ? product : null;
    }
    public static void UpdateProduct(Product product, int id)
    {
        _Products[id] = product;
    }
}
