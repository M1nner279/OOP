using System.Collections.ObjectModel;

namespace MenuApp.Models
{
    public static class Menu
    {
        public static ObservableCollection<MenuItem> Items { get; } = new() 
        {
            new Food("Пицца", 24, "pizza.jpg",500, 1200),
            new Food("Бургер", 12, "burger.jpg",300, 800),
            new Drink("Кофе", 7, "coffee.png",250),
            new Drink("Чай", 5, "tea.png",200),
            new Dessert("Торт", 12, "cake.png",150, 500),
            new Dessert("Мороженое", 9, "icecream.png",100, 250),
            new Salad("Цезарь", 6, "ceasar.png", 100, 200),
            new Alcohol("Вино", 500, "vine.png",750, 12),
            new Alcohol("Пиво", 300, "beer.png",500, 7)
        };
    }
}