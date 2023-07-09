using System;
using System.Globalization;

public static class UnitOfMeasureHelper
{
    public static string FormatLength(this double length, CultureInfo culture)
    {      
        string unit = (culture.Name == "en") ? "in" : "cm";
        return $"{length} {unit}";
    }

    public static string FormatWeight(this double weight, CultureInfo culture)
    {        
        string unit = (culture.Name == "en") ? "lb" : "kg";
        return $"{weight} {unit}";
    }

    public static string FormatVolume(this double volume, CultureInfo culture)
    {      
        string unit = (culture.Name == "en") ? "oz" : "L";
        return $"{volume} {unit}";
    }
}