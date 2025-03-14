namespace MenuApp.Models;

public class Food : MenuItem
{
    public int Calories { get; set; }
    public int Mass { get; set; }
    public Food(string name, int price, string imagePath, int calories, int mass) : base(name, price, imagePath)
    {
        Calories = calories;
        Mass = mass;
    }
    protected override string toString()
    {
        return base.toString() + $"Вес: {Mass} г\nКалорийность: {Calories} ккал";
    }
}