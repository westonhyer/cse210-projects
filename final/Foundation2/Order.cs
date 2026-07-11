using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
   
    public void CalculateCost()
    {
        double total = 0;
        double shippingFee = 35.00;
        foreach (Product product in _products)
        {
            double cost = product.GetTotalCost();
            total += cost;
        }
        if (_customer.ShippingDiscount())
        {
            shippingFee = 5.00;
            Console.WriteLine($"Subtotal: ${total}");
            Console.WriteLine($"Shipping: ${shippingFee}");
            Console.WriteLine($"Total: {total + shippingFee}");
        }
        else
        {
            Console.WriteLine($"Subtotal: ${total}");
            Console.WriteLine($"Shipping: ${shippingFee}");
            Console.WriteLine($"Total:    ${total + shippingFee}");
        }
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.CreatePackingLable()} ");
            Console.WriteLine();
        }
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetShippingLable()}";
    }
}