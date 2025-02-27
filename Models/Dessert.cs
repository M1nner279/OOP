namespace MenuApp.Models;

public class Dessert : Food
{
    public Dessert(string name, int price, string imgSource,  int calories, int mass) : base(name, price, imgSource, calories, mass) {}
}