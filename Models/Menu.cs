using System.Collections.ObjectModel;

namespace MenuApp.Models
{
    public static class Menu
    {
        public static ObservableCollection<MenuItem> Items { get; } = new() 
        {
            new Food("Пицца", 550, "pizza.jpg",500, 1200),
            new Food("Бургер", 350, "burger.jpg",300, 800),
            new Drink("Кофе", 150, "coffee.png",250),
            new Drink("Чай", 100, "tea.png",200),
            new Dessert("Торт", 250, "cake.png",150, 500),
            new Dessert("Мороженое", 200, "icecream.png",100, 250),
            new Alcohol("Вино", 500, "vine.png",750, 12),
            new Alcohol("Пиво", 300, "beer.png",500, 7)
        };
    }
}