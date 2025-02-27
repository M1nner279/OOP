namespace MenuApp.Models;

public class Alcohol : Drink
{
    public int Strength { get; set; }
    public Alcohol(string name, int price, string imgSource, int volume, int strength) : base(name, price, imgSource, volume)
    {
        Strength = strength;
    }
    public override string GetInfo => $"Объём: {Volume} мл\nКрепость: {Strength} %";
}