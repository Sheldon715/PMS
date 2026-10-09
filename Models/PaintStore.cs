using System;
using System.Data.Common;

namespace PMS.Models;

public class PaintStore
{
    public List<PaintProduct> paintStore { get; private set; }= new List<PaintProduct>();

    public void AddProduct(PaintProduct paintProduct)
    {
        paintStore.Add(paintProduct);
    }
}
