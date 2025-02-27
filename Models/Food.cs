namespace MenuApp.Models;

public class Food : MenuItem
{
    public int Calories { get; set; }
    public int Mass { get; set; }
    public Food(string name, int price, string imgSource, int calories, int mass) : base(name, price, imgSource)
    {
        Calories = calories;
        Mass = mass;
    }

    public override string GetInfo => $"Вес: {Mass} г\nКалорийность: {Calories} ккал";
}