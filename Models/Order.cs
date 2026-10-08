using System;

namespace PMS.Models;

public class Order
{
    public readonly DateTime CreatedAt;
    public int Quantity { get; set; }
    decimal TotalPrice { get; set; }

    public Order(PaintProduct[] paintProduct, int[] quantity)
    {
        CreatedAt = DateTime.Now;

        for (int i = 0; i < paintProduct.Length; i++)
        {
            TotalPrice += paintProduct[i].Price * quantity[i];
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
}
