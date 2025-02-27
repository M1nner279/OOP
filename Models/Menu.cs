using System.Collections.ObjectModel;

namespace laboop.Models
{
    public static class Menu
    {
        public static ObservableCollection<MenuItem> Items { get; } =
        [
            new Drink("Кофе", 150, 250),
            new Drink("Кола", 100, 300)
        ];
    }
}