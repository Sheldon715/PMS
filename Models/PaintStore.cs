using System;
using System.Data.Common;

namespace PMS.Models;

public class PaintStore
{
    PaintProduct[] paintStore = new PaintProduct[10];
    int count = 0;
    public void AddProduct(PaintProduct paintProduct)
    {
        paintStore[count] = paintProduct;
        count++;
    }
}
