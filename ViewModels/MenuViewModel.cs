using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MenuApp.Models;

namespace MenuApp.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Title { get; } = "Меню ресторана";
        public ObservableCollection<MenuItem> MenuItems { get; } = (Menu.Items);
        //---//
        public List<string> ItemTypes { get; } = new() { "Drink", "Food", "Alcohol", "Salad", "Dessert" };
        private string _selectedItemType = "Food";
        public string SelectedItemType
        {
            get => _selectedItemType;
            set
            {
                _selectedItemType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItemType)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsDrink)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsFood)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsAlcohol)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsDessert)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSalad)));
            }
        }
        public bool IsDrink => SelectedItemType == "Drink";
        public bool IsFood => SelectedItemType == "Food";
        public bool IsAlcohol => SelectedItemType == "Alcohol";
        public bool IsSalad => SelectedItemType == "Salad";
        public bool IsDessert => SelectedItemType == "Dessert";
        //---//
    
    }
}