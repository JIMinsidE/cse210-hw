public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.IsInUSA() ? 5.00m : 35.00m; // Add shipping fee based on location

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }
}