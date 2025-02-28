namespace MenuApp.Models;

public class Dessert : Food
{
    public Dessert(string name, int price, string imagePath,  int calories, int mass) : base(name, price, imagePath, calories, mass) {}
}