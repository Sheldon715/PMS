using System;

namespace PMS.Models;

public class Order
{
    public readonly DateTime CreatedAt;
    public int Quantity { get; private set; }
    public decimal TotalPrice { get; private set; }
    public List<PaintProduct> PaintProducts { get; private set; }

    public Order(List<PaintProduct> paintProducts, int[] quantity)
    {
        CreatedAt = DateTime.Now;
        PaintProducts = paintProducts;

        for (int i = 0; i < PaintProducts.Count; i++)
        {
            TotalPrice += PaintProducts[i].Price * quantity[i];
            Quantity += quantity[i];
        }
    }

    public void DisplayOrder()
    {
        System.Console.WriteLine($"Order {Quantity} items with total ${TotalPrice} at {CreatedAt}");
    }

    public void GetTotalPrice()
    {
        System.Console.WriteLine($"Total price is ${TotalPrice}");
    }

    public PaintProduct GetMostExpensivePaintProduct()
    {
        return PaintProducts.OrderByDescending(p => p.Price)
        .First();
    }

    public void RemoveProduct(int productId)
    {
        PaintProducts.RemoveAt(productId);
    }

    public IEnumerable<PaintProduct> SpecificRangeProduct(decimal X, decimal Y)
    {
        return PaintProducts.Where(p => p.Price > X && p.Price < Y);

    }

    public IEnumerable<decimal> AllProductPrice()
    {
        return PaintProducts
        .GroupBy(p => p.Type)
        .Select(group => group.Sum(p => p.Price));
    }
}
