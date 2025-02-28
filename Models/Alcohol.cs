namespace MenuApp.Models;

public class Alcohol : Drink
{
    public int Strength { get; set; }
    public Alcohol(string name, int price, string imagePath, int volume, int strength) : base(name, price, imagePath, volume)
    {
        Strength = strength;
    }
    public override string GetInfo => $"Объём: {Volume} мл\nКрепость: {Strength} %";
}