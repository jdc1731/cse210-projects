using System;
using System.Collections.Generic;

namespace OnlineOrdering;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public int GetNumberOfProducts()
    {
        return _products.Count;
    }
   public double CalculateTotalCost()
    {
    double total = 0;
    foreach (Product product in _products)
    {
        total += product.CalculateTotalCost();
    }

    if (_customer.IsInUSA())
        total += 5;   // shipping in USA
    else
        total += 35;  // shipping outside USA

    return total;
        }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} ({product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

}
