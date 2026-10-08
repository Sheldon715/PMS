using System;
using PMS.Enums;
using PMS.Interfaces;

namespace PMS.Models;

public class PaintProduct : IBuyable
{
    public readonly decimal TaxRate;
    public const decimal DefaultDiscount = 0.05m;

    public string Name { get; private set; }
    public PaintType Type { get; private set; }
    public PaintSpecification Specification { get; private set; }
    public decimal Price { get; private set; }
    Brand Brand;
    
    public PaintProduct(string name, PaintType type, PaintSpecification specification, decimal price)
    {
        Name = name;
        Type = type;
        Specification =specification;
        Price = price;
        TaxRate = 0.10m;
    }

    public decimal GetFinalPrice()
    {
        decimal finalPrice;
        finalPrice = Price * (1 - DefaultDiscount) * (1 + TaxRate);
        return finalPrice;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Name: {Name}, Type: {Type}, Specification: {Specification}, Price: {Price}");
    }

    public void GetMaxDiscount(int rate, bool isOverridable)
    {
        decimal maxDiscount;
        if (isOverridable)
        {
            maxDiscount = DefaultDiscount * rate;
        }
        else
        {
            maxDiscount = DefaultDiscount;
        }

        System.Console.WriteLine($"Max discount is {maxDiscount}");
    }
}
