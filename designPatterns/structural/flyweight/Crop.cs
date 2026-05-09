namespace structural.flyweight;
using System;
using System.Collections.Generic;

// Flyweight: спільний стан
public class CropType
{
    public string Name { get; }
    public int GrowthDays { get; }

    public CropType(string name, int growthDays)
    {
        Name = name;
        GrowthDays = growthDays;
    }
}

// Flyweight Factory
public class CropFactory
{
    private Dictionary<string, CropType> crops = new Dictionary<string, CropType>();

    public CropType GetCrop(string name, int growthDays)
    {
        if (!crops.ContainsKey(name))
        {
            crops[name] = new CropType(name, growthDays);
        }
        return crops[name];
    }
}

// Extrinsic state: конкретна грядка
public class PlantedCrop
{
    private CropType cropType;
    private int x;
    private int y;
    private int currentDay;

    public PlantedCrop(CropType cropType, int x, int y, int currentDay)
    {
        this.cropType = cropType;
        this.x = x;
        this.y = y;
        this.currentDay = currentDay;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Seedbed ({x},{y}): {cropType.Name}, day {currentDay}/{cropType.GrowthDays}");
    }
}


