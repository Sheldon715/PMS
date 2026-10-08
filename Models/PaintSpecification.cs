using System;

namespace PMS.Models;

public class PaintSpecification
{
    public string Color{ get; private set; }
    public int SizeLiters{ get; private set; }

    public PaintSpecification(string color, int sizeLiters)
    {
        Color = color;
        SizeLiters = sizeLiters;
    }

    public void DisplaySpecification()
    {
        System.Console.WriteLine($"Color: {Color}, SizeLiters: {SizeLiters}");
    }
}
