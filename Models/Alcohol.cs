namespace MenuApp.Models;

public class Alcohol : Drink
{
    public int Strength { get; set; }
    public Alcohol(string name, int price, string imagePath, int volume, int strength) : base(name, price, imagePath, volume)
    {
        Strength = strength;
    }
    protected override string toString()
    {
        return base.toString() + $"Крепость: {Strength} %";
    }
}