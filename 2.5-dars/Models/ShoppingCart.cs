namespace _2._5_dars.Models;

public class ShoppingCart
{
    private List<Product> _products;

    public ShoppingCart()
    {
        var _products = new List<Product>();
    }
    public Product AddToCart(Product product)
    {
        _products.Add(product);
        return product;
    }
    public double PriceToCart()
    {
        double balance = 0;
        foreach (var product in _products)
        {
            balance+= product.Price*product.Stok;
        }
        return balance;
    }
}
