using System.Collections.ObjectModel;
using MenuApp.Models;

namespace MenuApp.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public string Welcome { get; } = "Меню ресторана";
        public ObservableCollection<MenuItem> MenuItems { get; } = (Menu.Items);
        
    }
}