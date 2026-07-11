using System;

public class Product
{
    private string _name;
    private string _productID;
    private double _cost;
    private int _quantity;

    public Product(string name, string productID, double cost, int quantity)
        {
            _name = name;
            _productID = productID;
            _cost = cost;
            _quantity = quantity;
        }

    public string CreatePackingLable()
    {
        return $"{_name}\nID: {_productID}\nPrice: {_cost}\nQuantity: {_quantity}";
    }

    public double GetTotalCost()
    {
        return _cost * _quantity;
    }
}