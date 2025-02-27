using System.Collections.ObjectModel;

namespace MenuApp.Models
{
    public static class Menu
    {
        public static ObservableCollection<MenuItem> Items { get; } = new() 
        {
            new Food("Пицца", 550, "pizza.jpg",500, 1200),
            new Food("Бургер", 350, "",300, 800),
            new Food("Салат Цезарь", 300,"", 200, 350),
            new Drink("Кофе", 150, "coffee.png",250),
            new Drink("Чай", 100, "",200),
            new Drink("Сок", 120, "",300),
            new Dessert("Торт", 250, "",150, 500),
            new Dessert("Мороженое", 200, "",100, 250),
            new Alcohol("Вино", 500, "",750, 12),
            new Alcohol("Пиво", 300, "",500, 7)
        };
    }
}